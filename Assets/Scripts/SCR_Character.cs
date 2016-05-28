using UnityEngine;
using System.Collections;

public enum ConstructState
{
	Nothing,
	CreatingPoint
}

public class SCR_Character : MonoBehaviour
{
	public static SCR_Character Instance;

	public Transform ViewDirection;

//	public bool Moving = false;

	public SCR_MoveTarget Target;
	public GvrHead Head;

	public float Speed = 1;

	public ConstructState State;

	public SCR_LatticePoint CurrentPoint;
	public SCR_LatticeJoint CurrentJoint;

	public GameObject PointPrefab;
	public GameObject JointPrefab;
	public float CreateDistance;

//	public SCR_LatticePoint

	public void Awake ()
	{
		Instance = this;
	}
	
	public void Update ()
	{
		if(GvrViewer.Instance.Triggered)
		{
			var gaze = Head.Gaze;

			if(State == ConstructState.CreatingPoint)
			{
				State = ConstructState.Nothing;

				RaycastHit info;
				if(Physics.Raycast(gaze, out info))
				{
					if(info.collider.tag == "Lattice Point")
					{
						CurrentJoint.B = info.collider.gameObject.GetComponent<SCR_LatticePoint>();

						Destroy(CurrentPoint.gameObject);
					}
				}

				CurrentJoint.Init();
				CurrentJoint.Active = true;
				CurrentPoint.Init();

				CurrentPoint.GetComponent<Collider>().enabled = true;

				CurrentPoint = null;
				CurrentJoint = null;
			}
			else
			{
				RaycastHit info;
				if(Physics.Raycast(gaze, out info))
				{
					// Move
					if(info.collider.tag == "Ground")
					{
						Target.Active = true;
						Target.transform.position = info.point;
					}
					// Lattice
					else if(info.collider.tag == "Lattice Point")
					{
						State = ConstructState.CreatingPoint;

						CurrentPoint = Instantiate(PointPrefab).GetComponent<SCR_LatticePoint>();
						CurrentJoint = Instantiate(JointPrefab).GetComponent<SCR_LatticeJoint>();

						CurrentJoint.Active = false;
						CurrentPoint.Active = false;

						CurrentJoint.A = info.collider.gameObject.GetComponent<SCR_LatticePoint>();
						CurrentJoint.B = CurrentPoint;

						CurrentPoint.GetComponent<Collider>().enabled = false;

						CreateDistance = info.distance;
					}
				}
			}
		}

		if(State == ConstructState.CreatingPoint)
		{
			var gaze = Head.Gaze;
//			CurrentJoint
			CurrentPoint.transform.position = gaze.origin + gaze.direction * CreateDistance;
			CurrentPoint.UpdateCollision();
		}
		else if (State == ConstructState.Nothing)
		{
			// Update Movement
			if(Target.Active)
			{
				var target = new Vector3(Target.transform.position.x, transform.position.y, Target.transform.position.z);

				transform.position = Vector3.MoveTowards(transform.position, target, Time.smoothDeltaTime * Speed * 3F);
			}
		}
	}

//	public void GotoViewPosition()
//	{
//	}

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
