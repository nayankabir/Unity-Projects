using UnityEngine;
using System.Collections;

//Student Name: Ahsanul Kabir
//Student Number: 300828740
//COMP305 Assignment 1 - Centennial College


//object will be destryoed when inside boundary
public class Done_DestroyByBoundary : MonoBehaviour
{
	void OnTriggerExit (Collider other)
	{
		Destroy(other.gameObject);
	}
}
