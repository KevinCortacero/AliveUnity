using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTopDownScript : MonoBehaviour {

	[SerializeField]
	private Transform m_target;

	[SerializeField]
	private float m_height = 10f;

	[SerializeField]
	private float m_distance = 20f;

	[SerializeField]
	private float m_angle = 45f;

	[SerializeField]
	private float m_smoothSpeed = 0.5f;

	private Vector3 refVelocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.HandleCamera();
	}

	void HandleCamera(){

		if (!this.m_target)
			return;

		Vector3 worldPosition = (Vector3.forward * -m_distance) + (Vector3.up * m_height);
		Vector3 rotateVector = Quaternion.AngleAxis(m_angle, Vector3.up) * worldPosition;

		Vector3 flatTargetPosition = m_target.position;
		flatTargetPosition.y = 3f;
		Vector3 finalPosition = flatTargetPosition + rotateVector;

		transform.position = Vector3.SmoothDamp(transform.position, finalPosition, ref refVelocity, m_smoothSpeed);
		transform.LookAt(flatTargetPosition);
	}

}

