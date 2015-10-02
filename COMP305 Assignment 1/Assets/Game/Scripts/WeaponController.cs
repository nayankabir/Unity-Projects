using UnityEngine;
using System.Collections;

//Student Name: Ahsanul Kabir
//Student Number: 300828740
//COMP305 Assignment 1 - Centennial College

public class Done_WeaponController : MonoBehaviour
{
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;

	void Start ()
	{
		InvokeRepeating ("Fire", delay, fireRate);
	}

	void Fire ()
	{
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		GetComponent<AudioSource>().Play();
	}
}
