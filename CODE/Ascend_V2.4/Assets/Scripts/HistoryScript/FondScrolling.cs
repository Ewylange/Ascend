using UnityEngine;
using System.Collections;

public class FondScrolling : MonoBehaviour 
{
	public float speed = 0;
	public static FondScrolling current;

	float pos = 0;
	

	void Start()
	{
		current = this;
	}

	public void Go()
	{
		pos += speed;
		if(pos > 1.0f)
		{
			pos -= 1.0f;
		}

		GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0,pos);
	}
}
