#pragma strict

//Les effets de l'icy block sont places dans le srcipt line
//Ici on valide les effets on dit si ils s'appliquent ou pas
var shallBeSlowed: boolean = false;
public var timeSlowed: int = 5;

//=====================================================================================
function OnCollisionEnter(collision : Collision) 
{
	if(collision.gameObject.name == "icyBlock")
	{
		Destroy(collision.gameObject);
		shallBeSlowed=true;
		yield WaitAndPrint();
	}
}
//=====================================================================================

//=====================================================================================
function WaitAndPrint () 
{
	yield WaitForSeconds (timeSlowed);
	shallBeSlowed=false;
}
//=====================================================================================