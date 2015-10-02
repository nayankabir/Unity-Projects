using UnityEngine;
using System.Collections;

//Student Name: Ahsanul Kabir
//Student Number: 300828740
//COMP305 Assignment 1 - Centennial College

public class Done_Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}
