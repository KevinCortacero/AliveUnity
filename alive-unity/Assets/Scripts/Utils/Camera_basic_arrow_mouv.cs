using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_basic_arrow_mouv : MonoBehaviour {
	public float speed = 5.0f;
	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;	
	}
	
	// Update is called once per frame

	 void Update()
	 {
	 	transform.position = player.transform.position + offset;
	 }
}
