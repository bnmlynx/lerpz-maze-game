using UnityEngine;
using System.Collections;

public class EnemyDeathMessage : MonoBehaviour {

	[SerializeField]
	private GameObject enemyParent;
	// Use this for initialization
	void OnTriggerEnter(Collider collider) {

		if (collider.gameObject.tag == "Player") {

			enemyParent.SendMessage("OnDeath");

			//gameObject.SendMessageUpwards("OnDeath");
		}
	}
}
