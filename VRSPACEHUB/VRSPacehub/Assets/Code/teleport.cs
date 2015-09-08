using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {
	
	public GameObject Spaceship; 
	public string levelname; 
	public bool switchCamera = false; 
	GameObject[] spaceships; 	 
	
	// Use this for initialization
	void Start () {
		//List<transform> abc = new List<transform>();  
		spaceships = GameObject.FindGameObjectsWithTag("Spaceship");  
		foreach(GameObject child in spaceships)
		{
			spaceships.Push(child.transform); 
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void findClosestSpaceShip(Transform[] closests) 
	{ 
	
	}
	
	void OnTriggerEnter(Collider other) 
	{ 
		//Application.LoadLevel(levelname);
	
		GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = false; 
		GameObject.FindGameObjectWithTag("SpaceShipCamera").GetComponent<Camera>().enabled = true; 	
		Spaceship.GetComponent<ShipMovement>().move = true; 
		GameObject.FindGameObjectWithTag("Player").transform.parent=Spaceship.transform; 
		
	} 
	
}
