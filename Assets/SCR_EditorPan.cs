using UnityEngine;
using System.Collections;

public class SCR_EditorPan : MonoBehaviour 
{
	#if UNITY_EDITOR
	public void Start () 
	{
		var head = this.GetComponent<GvrHead>();
		head.trackRotation = false;
	}

	Vector2? lastPosition;

	Vector2 localRotation;
	
	public void Update () 
	{
		if(Input.GetMouseButton(1))
		{
			if(lastPosition != null)
			{
				Vector2 diff = lastPosition.Value - (Vector2) Input.mousePosition;

				localRotation += diff * 0.2F;

				var head = this.GetComponent<GvrHead>();

				head.transform.localRotation = Quaternion.Euler(localRotation.y, -localRotation.x, 0);
			}

			lastPosition = Input.mousePosition;
		}
		else
		{
			lastPosition = null;
		}
	}
	#endif
}
