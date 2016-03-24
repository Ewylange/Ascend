using UnityEngine;
using System.Collections;

//Se script se met sur les ennemis qui tirent
public class turretLikeEnnemies : MonoBehaviour
{
	//set target from inspector instead of looking in Update
	private GameObject target;
	
	public Rigidbody projectile;
	public float rateDeTir = 2;
	float timeLeft = 0;
	//================================================================================================================================
	void Start ()
	{
		target = GameObject.Find("Player");
		timeLeft = rateDeTir;
	}
	//================================================================================================================================
	
	//================================================================================================================================
	void Update ()
	{
		//rotate to look at the player
		if (target)
		{
			timeLeft -= Time.deltaTime;
		}
		transform.LookAt(target.transform.position);
		transform.Rotate(new Vector3(0,-90,0),Space.Self);//correcting the original rotation

		if(timeLeft < 0)
		{
			timeLeft = rateDeTir;
			Rigidbody clone;
			clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.right * 10);
		}
	}
	//================================================================================================================================
}
