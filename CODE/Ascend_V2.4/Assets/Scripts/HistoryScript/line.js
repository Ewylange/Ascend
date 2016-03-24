	var pos1 : Vector3;
 	var pos2 : Vector3;
 	public var MaxVelocityBall : float = 15.0f;
 	public var _tailleDeLaLigne = pos2 - pos1;
 	//Pour les icy blocks je met ici la division de jump ici
 	//Mais j'ai mis dans le script du player une autre partie qui correspond au temp de l'effet
 	public var icyBlockLessJump: float = (3/4);
 	//public var icyBlockTimeEffect: float = 2;
 	var playerVars: GameObject;
 	public var other: GameObject;
 	public var _player: GameObject;
 	public var _plusPetiteHauteur: float;
  
  function Start()
  {
  	playerVars = GameObject.Find("Player");
  	_player = GameObject.Find("Player");
  }
  
 function Update () 
 {
  	//================================================================================================================================
  	//Si false that line rend une bool qui est false ele va rendre la ligne rouge
  	if(playerVars.gameObject.GetComponent(FalseThatLine).dontDoTheLine == false)
    {
    	other.GetComponent.<Renderer>().material.color = Color.red;
  	}
  	//================================================================================================================================
  	
  	
  	//================================================================================================================================
  	//Ceci nous permet de changer la position du cube et aussi ça taille
     if (Input.GetMouseButtonDown(0)) 
     {
     	//SlowMotion
     	if (Time.timeScale == 1.0F || Time.timeScale == 0.9F)
     	{
	        Time.timeScale = 0.7F;
        }
     	//SlowMotion
     
     	other.GetComponent.<Renderer>().material.color = Color.white;
     	//Cette ligne nous permet d'avoir la creation de ligne exacte avec la souris sauf que pour le tactile nous allons l'augmenter pour l'aisser plus de pouvoir au joueur
       	//pos1 = Vector3(Input.mousePosition.x + 0 , Input.mousePosition.y + 0, Camera.main.nearClipPlane + 20);
       	
       	//En rajoutant -20 d'un cote et +20 de l'autre la ligne est de base plus grande que celle dessinee par la souris
       	//c'est pour cela que sur pc cette difference se voit, mais a cause du doigt sa ne se vera surement pas et on donnera
       	//une plus grande marge d'erreur au joueur
       	
       	pos1 = Vector3(Input.mousePosition.x - 15, Input.mousePosition.y + 0, Camera.main.nearClipPlane + 20);
       	
       	pos1 = Camera.main.ScreenToWorldPoint(pos1); 
       	pos2 = pos1;
       	
       	//CECI est pour activer le box collider depuis le debut du trace
       	var script2 : BoxCollider = gameObject.GetComponent(BoxCollider); 
     	script2.enabled = true;
     	other.GetComponent.<Renderer>().material.color = Color.green;
     }
  
     if (Input.GetMouseButton(0)) 
     {
       //Cette ligne nous permet d'avoir la creation de ligne exacte avec la souris sauf que pour le tactile nous allons l'augmenter pour l'aisser plus de pouvoir au joueur
       //pos2 = Vector3(Input.mousePosition.x + 0, Input.mousePosition.y + 0, Camera.main.nearClipPlane + 20);
       
       //En rajoutant -20 d'un cote et +20 de l'autre la ligne est de base plus grande que celle dessinee par la souris
       //c'est pour cela que sur pc cette difference se voit, mais a cause du doigt sa ne se vera surement pas et on donnera
       //une plus grande marge d'erreur au joueur
       
       pos2 = Vector3(Input.mousePosition.x + 15, Input.mousePosition.y + 0, Camera.main.nearClipPlane + 20);
       	
       pos2 = Camera.main.ScreenToWorldPoint(pos2); 
     }
  
     if (pos2 != pos1) 
     {
       	var v3 = pos2 - pos1;
       	transform.position = pos1 + (v3) / 2.0;
	    transform.localScale.y = v3.magnitude;
	    transform.rotation = Quaternion.FromToRotation(Vector3.up, v3);
     }
     //================================================================================================================================
   
    
     //================================================================================================================================	
     //le truc ne se cree pas tant que tu n'as pas relache le doight
     if(Input.GetMouseButtonUp(0))
     {
     	//slow motion
     	if (Time.timeScale == 0.7F)
     	{
	        Time.timeScale = 0.9F;
        }
     	//Slow Motion
     	
     	//Le boxcollider qui permet de rebondir ne sera pas active si la souris passe dessus du player du coup la boulle va pas rebondir dessus
     	if(playerVars.gameObject.GetComponent(FalseThatLine).dontDoTheLine == true)
     	{
     		//var script : BoxCollider = gameObject.GetComponent(BoxCollider); 
     		//script.enabled = true;
	     	//GetComponent("BoxCollider").enabled=true;
	     	//other.renderer.material.color = Color.green;
	  		//GetComponent("MeshRenderer").enabled=true;
  		}
  	 }
  	 //================================================================================================================================


	 //================================================================================================================================
  	 // Ceci nous permet d'avoir la box des qu'on la dessine
  	 if (Input.GetMouseButtonDown(0)) 
     {
    	playerVars.gameObject.GetComponent(FalseThatLine).dontDoTheLine = true;
     	DrawMe ();
     }
     //================================================================================================================================
 
	//================================================================================================================================ 
	//Ceci me permet d'obtenir la taille de la ligne
 	_tailleDeLaLigne = pos2 - pos1;
 	//Debug.Log( _tailleDeLaLigne.magnitude);
 	//================================================================================================================================
 	
 	//================================================================================================================================
 	//Ceci me permet d'obtenir le point le plus petit des deux bouts de la ligne! 
 	//que j'utilise plus tard comme condition pour ne pas faire rebondir la balle
 	//Remarque: la ligne ne rejoutera pas de force sur la balle si elle cogne la partie basse de la ligne
 	if(pos1.y<pos2.y)
 	{
 	 	_plusPetiteHauteur = pos1.y;
 	}
 	if(pos2.y<pos1.y)
 	{
 	 	_plusPetiteHauteur = pos2.y;
 	}
 	//================================================================================================================================
 }
 
 //================================================================================================================================
 //J'ai du yield parceque pendant une frame on vayait la box sur sa derniere position apres 0,1s la box est visible et son collider l'est aussi
  function DrawMe ()
 {
     yield WaitForSeconds (0.1f);
    // GetComponent("BoxCollider").enabled=true;
    var script : MeshRenderer = gameObject.GetComponent(MeshRenderer); 
    script.enabled = true;
  	//GetComponent("MeshRenderer").enabled=true;
 }
 //================================================================================================================================
 
 //================================================================================================================================
 //Ceci me permet de donner une velocity a la balle quand elle entre en collision avec ma barre
 //J'utilise stay parceque apres plusieurs test c'etait celui qui me donnait le moin d'erreurs
 //L'idee est de diviser la maxvelocity de la balle par la taille de la barre
 // Cependant je la limite a diviser par 1 (ou le resultat sera trop grand) ex: 12/0.1= 120
 //Mais je limite aussi le maximum parceque si le nombre est trop petit la balle ne rebondit presque pas, a modifier la limite max en dependant de ce que l'on choisi bien sur
 //J'ai choisi 6 parceque c'est la taille maximale sur l'ecran! a modifier si on change la taille de l'ecran
 function OnCollisionEnter(collision : Collision) 
 {

 	if(collision.gameObject.name == "Player" && (_player.transform.position.y > _plusPetiteHauteur))
 	{
 		var resultat : float;
 		//=====================================================================================
 		//Plus petit que un
 		if(_tailleDeLaLigne.magnitude <= 1.0f)
 		{
 			if(playerVars.gameObject.GetComponent(CollidedWithIcyBloc).shallBeSlowed == false)
 			{
 				resultat = 12;
 			}
 			if(playerVars.gameObject.GetComponent(CollidedWithIcyBloc).shallBeSlowed == true)
 			{
 				resultat = (12*icyBlockLessJump);
 			}
 		}
 		//=====================================================================================
 		
 		//=====================================================================================
 		//Entre une taille 1 et 6
 		if(_tailleDeLaLigne.magnitude > 1.0f && _tailleDeLaLigne.magnitude < 3.0f)
 		{
 			if(playerVars.gameObject.GetComponent(CollidedWithIcyBloc).shallBeSlowed == false)
 			{
 				resultat = 10.0f;
 				}
 			if(playerVars.gameObject.GetComponent(CollidedWithIcyBloc).shallBeSlowed == true)
 			{
 				resultat = (10*icyBlockLessJump);
 			}
 		}
 		
 		if(_tailleDeLaLigne.magnitude >= 3.0f && _tailleDeLaLigne.magnitude < 6.0f)
 		{
 			if(playerVars.gameObject.GetComponent(CollidedWithIcyBloc).shallBeSlowed == false)
 			{
 				resultat = 8.0f;
 			}
 			if(playerVars.gameObject.GetComponent(CollidedWithIcyBloc).shallBeSlowed == true)
 			{
 				resultat = (8*icyBlockLessJump);
 			}
 		}
 		//=====================================================================================
 		
 		//=====================================================================================
 		//Plus grand que 6
 		if(_tailleDeLaLigne.magnitude >= 6.0f)
 		{
 			if(playerVars.gameObject.GetComponent(CollidedWithIcyBloc).shallBeSlowed == false)
 			{
 				resultat = 6;
 			}
 			if(playerVars.gameObject.GetComponent(CollidedWithIcyBloc).shallBeSlowed == true)
 			{
 				resultat = (6*icyBlockLessJump);
 			}
 		}
 		//=====================================================================================
 		
 		collision.rigidbody.velocity.y = resultat;
 		
 		//Pour un mouvement plus realiste
 		if(collision.rigidbody.velocity.x < 0)
 		{
 			collision.rigidbody.velocity.x = -resultat/2;
 		}
 		
 		if(collision.rigidbody.velocity.x > 0)
 		{
 			collision.rigidbody.velocity.x = resultat/2;
 		}
 	}
 }
//================================================================================================================================
 
