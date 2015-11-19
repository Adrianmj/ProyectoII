using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Movimiento : MonoBehaviour
{
	public int speed = 2;
	private void Start()
	{
	}
		
		
	private void Update ()
	{
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}