using UnityEngine;
using System.Collections;

public class SCR_LatticeJoint : MonoBehaviour 
{
	public SCR_LatticePoint A;
	public SCR_LatticePoint B;

	public float Distance;
	public float Stiffness = 1;

	public bool Active = true;

	public void Start()
	{
		if(A == null || B == null)
		{
			return;
		}

		Distance = (A.transform.position - B.transform.position).magnitude;
	}

	public void LateUpdate () 
	{
		if(A == null || B == null)
		{
			return;
		}

		var diff = A.transform.position - B.transform.position;
		var length = diff.magnitude;

		var norm = length == 0 ? Vector3.up : diff / length;

		if(Active)
		{
			var push = length - Distance;

			var impulse = (norm * push) * Stiffness * Time.deltaTime;

			A.Velocity -= impulse;
			B.Velocity += impulse;
		}

		transform.position = (A.transform.position + B.transform.position) * 0.5F;
		transform.rotation = Quaternion.LookRotation(norm);
		transform.localScale = new Vector3(1, 1, length * 0.5F);
	}
}
