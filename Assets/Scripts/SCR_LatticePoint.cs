using UnityEngine;
using System.Collections;

public class SCR_LatticePoint : MonoBehaviour 
{
	public float Radius = 0.2F;
	public float BounceDamping = 0.8F;

	public float Damping = 0.96F;
	public float Gravity = 1;

	public Vector3 Velocity;
	public bool Active = true;

//	public SCR_LatticePoint

	public void Start()
	{
		Init();
	}

	public void Init()
	{
		Active = SCR_ToggleLatticePhysics.Instance.Active;
	}

	public void Update () 
	{
		if(!Active)
		{
			return;
		}

		transform.position += Velocity * Time.deltaTime;

		UpdateCollision();

		Velocity = new Vector3(
			Velocity.x * Damping,
			Velocity.y * Damping - Gravity * Time.deltaTime,
			Velocity.z * Damping);

	}

	public void UpdateCollision()
	{
		if(transform.position.y < Radius)
		{
			transform.position = new Vector3(
				transform.position.x, 
				Radius, 
				transform.position.z);

			Velocity = new Vector3(
				Velocity.x,
				Mathf.Abs(Velocity.y) * BounceDamping,
				Velocity.z);
		}
	}
}
