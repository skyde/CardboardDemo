using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;

public class SCR_ToggleLatticePhysics : MonoBehaviour 
{
	public static SCR_ToggleLatticePhysics Instance;

	public Renderer[] Renderers;

	public Color HighlightColor = Color.green;

	public bool Active = true;

	public void Awake()
	{
		Instance = this;

		Renderers = gameObject.GetComponentsInChildren<Renderer>();

		foreach (var item in Renderers) 
		{
			item.gameObject.AddComponent<DATA_Renderer>();
		}
	}

	public void SetHighlight (bool gazedAt)
	{
		foreach (var renderer in Renderers)
		{
			renderer.material.color = gazedAt ? HighlightColor : renderer.gameObject.GetComponent<DATA_Renderer>().InitalColor;
		}
	}


	public void OnGazeTrigger ()
	{
		Active = !Active;

		SetHighlight(!Active);

		foreach (var item in GameObject.FindObjectsOfType<SCR_LatticePoint>()) 
		{
			item.Active = Active;
		}

//		var body = GetComponent<Rigidbody>();
//
//		if(body)
//		{
//			body.AddForce(SCR_Character.Instance.Head.Gaze.direction * 700);
//		}
	}
}
