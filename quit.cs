using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour {


	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

}