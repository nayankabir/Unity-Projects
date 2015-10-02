using UnityEngine;
using System.Collections;

//Student Name: Ahsanul Kabir
//Student Number: 300828740
//COMP305 Assignment 1 - Centennial College


//rotates object in a randomized direction using unity's random class
public class Done_RandomRotator : MonoBehaviour
{
	public float tumble;

	void Start ()
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
	}
}
