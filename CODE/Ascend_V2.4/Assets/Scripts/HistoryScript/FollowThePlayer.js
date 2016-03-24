#pragma strict

//TOUT ca c'est pour monter avec le joueur

public var target : GameObject;
var height : float;
var lastheight : float;
//MYCAM correspond a la camera
public var MYCAM : Camera;
//Limites de jeu corresond au barres laterales et la barre inferieure
public var limitesDeJeu : GameObject;
public var fond: GameObject;
 
//=====================================================================================
function Start ()
{
	target = GameObject.Find("Player");
	fond = GameObject.Find("Fond");
	limitesDeJeu = GameObject.Find("Limites");
	
    height = target.transform.position.y;
    lastheight = MYCAM.transform.position.y;
}
//=====================================================================================

//=====================================================================================
function Update ()
{
     height = target.transform.position.y;
     lastheight = MYCAM.transform.position.y;
 
     if (height > lastheight)
     {
     	//Ce deplacer quand la height augmente trop
         MYCAM.transform.position.y = height;
         limitesDeJeu.transform.position.y = height;
         fond.gameObject.GetComponent(FondScrolling2).Go();
         fond.transform.position.y = height;
     }
 }
//=====================================================================================