using UnityEngine;
using System.Collections;

public class SCR_Character : MonoBehaviour
{
	public static SCR_Character Instance;

	public Transform ViewDirection;

//	public bool Moving = false;

	public SCR_MoveTarget Target;
	public GvrHead Head;

	public float Speed = 1;

	public void Awake ()
	{
		Instance = this;
	}
	
	public void Update ()
	{
//		Cardboard

//		if(GvrViewer.Instance.Triggered)
//		{
//			Moving = !Moving;
//		}

		if(Target.Active)
		{
			var target = new Vector3(Target.transform.position.x, transform.position.y, Target.transform.position.z);

			//ViewDirection.transform.forward

			transform.position = Vector3.MoveTowards(transform.position, target, Time.smoothDeltaTime * Speed * 3F);

//			transform.position = ;
		}
	}

	public void GotoViewPosition()
	{
		var ray = Head.Gaze;

		RaycastHit info;
		if(Physics.Raycast(ray, out info))
		{
			Target.Active = true;
			Target.transform.position = info.point;
		}
	}

//	public void OnDown()
//	{
//		Moving = true;
//	}
//
//	public void OnUp()
//	{
//		Moving = false;
//	}
}
