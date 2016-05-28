using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Renderer))]
public class DATA_Renderer : MonoBehaviour
{
	public Color InitalColor;

	public void Awake()
	{
		InitalColor = GetComponent<Renderer>().material.color;
	}
}
