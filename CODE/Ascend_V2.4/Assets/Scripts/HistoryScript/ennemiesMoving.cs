using UnityEngine;
using System.Collections;

public class ennemiesMoving : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.left * 2);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(gameObject.transform.position.x>2.4f)
		{
			GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.left * 2);
		}
		else if(gameObject.transform.position.x<-2.4f)
		{
			GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.right * 2);
		}
	}
}
