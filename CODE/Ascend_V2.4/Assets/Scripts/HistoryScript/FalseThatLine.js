#pragma strict
//=====================================================================================
//This will be used to not create the line when it collides with the mouse
public var dontDoTheLine: boolean = true;

function Start () 
{
	dontDoTheLine = true;
}
//=====================================================================================

//=====================================================================================
 //Mouse Over is a beautiful and lovely function to see if the player is selected
 //Si le joueur touche avec son doigt le player la ligne ne fera pas rebondir la balle
 function OnMouseOver()
 {
 	dontDoTheLine = false;
 }
 //=====================================================================================