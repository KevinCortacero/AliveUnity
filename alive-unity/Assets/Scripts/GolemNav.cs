using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemNav : MonoBehaviour {

	public Transform target;
	public UnityEngine.AI.NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	// Update is called once per frame
	void Update () {
		agent.destination = target.position;
	}
}
