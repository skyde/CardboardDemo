using UnityEngine;
using System.Collections;

public class SCR_Character : MonoBehaviour
{
	public Transform ViewDirection;

	public bool Moving = false;

	public void Start ()
	{
	
	}
	
	public void Update ()
	{
//		Cardboard

//		if(GvrViewer.Instance.Triggered)
//		{
//			Moving = !Moving;
//		}

		if(Moving)
		{
			var y = transform.position.y;

			transform.position += ViewDirection.transform.forward * Time.smoothDeltaTime;

			transform.position = new Vector3(transform.position.x, y, transform.position.z);
		}
	}

	public void OnDown()
	{
		Moving = true;
	}

	public void OnUp()
	{
		Moving = false;
	}
}
