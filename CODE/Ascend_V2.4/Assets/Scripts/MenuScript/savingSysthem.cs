//INFO: this script only saves the info for the first HUB
//INFO: This script must be updated while the game is created
//INFO: IF YOU WANT TO FIND WHERE THE DATA IS SAVED GO TO USER/APPDATA/LOCALLOW/"ANNEDDACOMPANYNAME"

using UnityEngine;
using System.Collections;
using System;

//We write the saving systhem in bnary so that the player can't write on the saved document, 
//they are unreadable if you don't know what is inside
using System.Runtime.Serialization.Formatters.Binary;

using System.IO;

public class savingSysthem : MonoBehaviour
{
	public static savingSysthem _saving;
	
	#region game stats
	public bool _lvl1 = true;
	public bool _lvl2 = false;
	public bool _lvl3 = false;
	public bool _lvl4 = false;
	public bool _lvl5 = false;
	public bool _lvl6 = false;
	public bool _lvl7 = false;
	public bool _lvl8 = false;
	
	public int _coinsNumber = 0;
	#endregion

	public int _actualLevelCoin;

	public string _actualLevelName;

	//Check some things at awake
	void Awake ()
	{
		if (_saving == null) {
			DontDestroyOnLoad (gameObject);
			_saving = this;
		} else if (_saving != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.A)) {
			Save ();
		}
		
		if (Input.GetKeyDown (KeyCode.L)) {
			Load ();
		}
	}
	
	
	//It is called when the player stops playmode
	void OnApplicationQuit ()
	{
		Save ();
	}
	
	
	/// <summary>
	/// This function lets you save the actual info of the game.
	/// It can be called by any script
	/// 
	///THIS WILL WORK ON ALL THE PLATFORMS: DESKTOP + MOBILE 
	///EXEPT WEB VERSION!
	/// </summary>
	public void Save ()
	{
		Debug.Log ("Game is saved");
		
		BinaryFormatter _bf = new BinaryFormatter ();
		// the string in _file will be the name of the file
		FileStream _file = File.Create (Application.persistentDataPath + "/playerInfoAnneddaGame.dat");
		
		PlayerData _data = new PlayerData ();
		
		//Data that is needed to be saved
		#region game stats
		_data.lvl1 = _lvl1;
		_data.lvl2 = _lvl2;
		_data.lvl3 = _lvl3;
		_data.lvl4 = _lvl4;
		_data.lvl5 = _lvl5;
		_data.lvl6 = _lvl6;
		_data.lvl7 = _lvl7;
		_data.lvl8 = _lvl8;

		_data.coinsNumber = _coinsNumber;
		#endregion
		
		_bf.Serialize (_file, _data);
		_file.Close ();
	}
	
	
	/// <summary>
	/// Loading function lets the player load the last save of the game.
	/// This function is public and can be called by any script
	/// </summary>
	public void Load ()
	{
		Debug.Log ("Game is Loaded");
		
		if (File.Exists (Application.persistentDataPath + "/playerInfoAnneddaGame.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfoAnneddaGame.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();
			
			//data that needs to be loaded
			#region game stats
			_lvl1 = data.lvl1;
			_lvl2 = data.lvl2;
			_lvl3 = data.lvl3;
			_lvl4 = data.lvl4;
			_lvl5 = data.lvl5;
			_lvl6 = data.lvl6;
			_lvl7 = data.lvl7;
			_lvl8 = data.lvl8;
			
			_coinsNumber = data.coinsNumber;
			#endregion
		}
	}
	
	//serializable = can be saved in file
	[Serializable]
	//This is the data that will be saved/loaded inside a file
	class PlayerData
	{
		//Container class of the data that is going to be saved
		#region game stats
		public bool lvl1;
		public bool lvl2;
		public bool lvl3;
		public bool lvl4;
		public bool lvl5;
		public bool lvl6;
		public bool lvl7;
		public bool lvl8;
		
		public int coinsNumber;
		#endregion
	}

}
