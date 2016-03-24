using UnityEngine;
using System.Collections;

public class wallsClosing : MonoBehaviour 
{
	public float _wallVelocity = 0.2f;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () 
	{
		foreach(Rigidbody r in GetComponentsInChildren<Rigidbody>())
		{
			if(r.name == "left")
			{
				r.velocity = transform.TransformDirection(Vector3.right * _wallVelocity);
			}
			if(r.name == "right")
			{
				r.velocity = transform.TransformDirection(Vector3.left * _wallVelocity);
			}
		}
	}
}
