using UnityEngine;
using System.Collections;

public class BatteryCollect : MonoBehaviour {
	public int charge = 0;

	public Texture2D charge0tex;
	public Texture2D charge1tex;
	
	// Use this for initialization
	void Start () {
		
		GetComponent<GUITexture>().enabled = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(charge == 1){
			
			GetComponent<GUITexture>().texture = charge1tex;
			GetComponent<GUITexture>().enabled = true;
						
		}
		
		// display subsequent textures to indicate power collected

		
		
		else if(charge == 0){
			
			GetComponent<GUITexture>().texture = charge0tex;
		}
		
		
	}
	
	public void setCharge(){
		
		// updates the charge variable via a message
		// from the PlayerCollions script
		
		charge = charge + 1 ;
	}
}