using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

	public float rotationAmount = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// rotate the battery in the y axis 
		transform.Rotate( 0f, rotationAmount, 0f );
	
	}
}
