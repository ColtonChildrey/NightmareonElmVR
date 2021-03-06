using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour
{
	public float speed = 1f;
	private GameObject myGo;
	private Rigidbody myRb;


	// Use this for initialization
	void Start ()
	{
		myGo = this.gameObject;
		myRb = myGo.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");

		myRb.AddForce(new Vector3(x, 0, z) * speed);


	}
	void Update ()
	{
		myRb.LookAt(GameObject.Find("Player").transform);
	}
	private void OnCollisionEnter(Collision collision)
	{
		print (collision.gameObject.name);
		if (collision.gameObject.tag == "Enemy") 
		{
			Destroy (collision.gameObject);
		}
	}
}

