#pragma strict

public static var  current : FondScrolling2;
public var speed : float = 0.001f;
public var pos : float = 0;

function Start () 
{
	current = this;
}

public function Go () 
{
	pos += speed;
		if(pos > 1.0f)
		{
			pos -= 1.0f;
		}

		GetComponent.<Renderer>().material.mainTextureOffset = new Vector2(0,pos);
}