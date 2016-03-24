using UnityEngine;
using System.Collections;

public class PortalRotate : MonoBehaviour 
{
	public int sensDeRotate = 1;
	public float speed = 10f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.Rotate(Vector3.forward * sensDeRotate * speed * Time.deltaTime);
	}
}
