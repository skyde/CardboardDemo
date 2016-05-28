using UnityEngine;
using System.Collections;

public class SCR_InteractiveObject : MonoBehaviour 
{
	public Renderer[] Renderers;

	public Color HighlightColor = Color.green;

	public void Awake()
	{
		Renderers = gameObject.GetComponentsInChildren<Renderer>();

		foreach (var item in Renderers) 
		{
			item.gameObject.AddComponent<DATA_Renderer>();
		}
	}

	public void SetGazedAt (bool gazedAt)
	{
		foreach (var renderer in Renderers)
		{
			renderer.material.color = gazedAt ? HighlightColor : renderer.gameObject.GetComponent<DATA_Renderer>().InitalColor;
		}
//		var r = GetComponent<Renderer> ();

//		if(r)
//		{
//			r.material.color = gazedAt ? Color.green : Color.red;
//		}
	}

	public void OnGazeEnter ()
	{
		SetGazedAt (true);
	}

	public void OnGazeExit ()
	{
		SetGazedAt (false);
	}

	public void OnGazeTrigger ()
	{
//		TeleportRandomly ();
	}
}
