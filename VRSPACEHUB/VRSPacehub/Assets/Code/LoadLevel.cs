using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	public string levelname; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) 
	{ 	
		print("feafe");
		Application.LoadLevel(levelname);
	}
}
