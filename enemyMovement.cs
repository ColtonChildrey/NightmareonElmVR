using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {
	public float speed = 1f;

	private GameObject myGo;
	private Transform myTransform;


	// Use this for initialization
	void Start () {
		myGo = this.gameObject;
		myTransform = myGo.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		myTransform.position += myTransform.forward * speed * Time.deltaTime;
		myTransform.LookAt(GameObject.Find("Player").transform);
	}
}
