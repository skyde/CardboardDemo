using UnityEngine;
using System.Collections;

public class SCR_MoveTarget : MonoBehaviour
{
	public SCR_Character Character;
	public bool Active;

	public Transform Graphic;

	public void Update () 
	{
		Graphic.gameObject.SetActive(Active);
	}
}
