using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

	public int score;

	GameObject updateHUD;
	
	void Start () {
		
		updateHUD = GameObject.Find("HUD");

		score = 0;
		
	}
	
	void Update () {
		
	}
	
	public void OnTriggerEnter(Collider collisionInfo){
		
		
		if(collisionInfo.gameObject.tag == "battery"){
			
			updateHUD.GetComponent<BatteryCollect>().setCharge();

			score++;
			Destroy(collisionInfo.gameObject);


			
		}

		if(collisionInfo.gameObject.tag == "map"){
			
			updateHUD.GetComponent<MapCollect>().setMap();

			Destroy(collisionInfo.gameObject);
			
			
			
		}




		if (collisionInfo.gameObject.tag == "spaceship") 
		{
			if (score > 0)
			{
				Application.LoadLevel ("End");

			}

		}
		
	}
	
}
