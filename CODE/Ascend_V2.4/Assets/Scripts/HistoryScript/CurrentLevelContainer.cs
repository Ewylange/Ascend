using UnityEngine;
using System.Collections;

public class CurrentLevelContainer : MonoBehaviour {

	private static bool created = false;
	public int _level;
	private GameObject nextLevel;
	private GameObject menu;
	void Awake()
	{ 
		if (!created) 
		{ 
			// this is the first instance - make it persist 
			DontDestroyOnLoad(this.gameObject); 
			created = true; 
		} 
		else 
		{ // this must be a duplicate from a scene reload - DESTROY! 
			Destroy(this.gameObject); 
		} 
	}

	void Start()
	{
		/*if(Application.loadedLevel != 7)
		{
			_level = Application.loadedLevel;
		}

		if(Application.loadedLevel == 7)
		{
			nextLevel = GameObject.Find("NextLevel");
			menu = GameObject.Find ("Menu");
		}*/
	}

	void Update()
	{
		if(Application.loadedLevel != 12)
		{
			_level = Application.loadedLevel;
		}
		
		if(Application.loadedLevel == 12)
		{
			nextLevel = GameObject.Find("NextLevel");
			menu = GameObject.Find ("Menu");
		}

		if(Input.GetMouseButtonDown(0) && Application.loadedLevel == 12)
		{
			CastRay();
		}
	}

	void CastRay()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, 100))
		{
			//Debug.DrawLine(ray.origin, hit.point);
			//Debug.Log ("Hit object: " + hit.collider.gameObject.name);
			if(hit.collider.gameObject.name == "NextLevel")
			{
				//Maxlevels now is 6 later the number will be higher
				if(_level <= 12)
				{
					_level ++;
					Application.LoadLevel(_level);
				}
			}

			if(hit.collider.gameObject.name == "Menu")
			{
				Application.LoadLevel("ModeSelection");
			}
		}
	}
}
