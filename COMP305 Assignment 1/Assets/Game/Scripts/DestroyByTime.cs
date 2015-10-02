using UnityEngine;
using System.Collections;

//Student Name: Ahsanul Kabir
//Student Number: 300828740
//COMP305 Assignment 1 - Centennial College

//object will be destroyed after a set time
public class Done_DestroyByTime : MonoBehaviour
{
	public float lifetime;

	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}
