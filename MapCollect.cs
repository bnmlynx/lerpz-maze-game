using UnityEngine;
using System.Collections;

public class MapCollect : MonoBehaviour {
	public int map = 0;
	
	public Texture2D charge1tex;
	public Texture2D charge0tex;
	
	public GameObject miniMap;
	
	// Use this for initialization
	void Start () {
		
		GetComponent<GUITexture>().enabled = false;
		map = 0;
		
		
		miniMap.SetActive (false);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (map == 1) {

			miniMap.SetActive (true);
		}

	}
	
	public void setMap(){
		
		// updates the charge variable via a message
		// from the PlayerCollions script
		
		map = map + 1 ;
	}
}