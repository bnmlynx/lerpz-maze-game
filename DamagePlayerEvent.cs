using UnityEngine;
using System.Collections;

public class DamagePlayerEvent : MonoBehaviour {

	public AudioClip hit;

	public Animation animationAttack;


	public delegate void DamagePlayerAction(GameObject player);
	public static event DamagePlayerAction OnDamagePlayer;

	void OnTriggerEnter(Collider collider) {
	
		if (collider.gameObject.tag == "Player") {
			if (OnDamagePlayer != null) {
				OnDamagePlayer(collider.gameObject);
				animationAttack.Play ("Attack1");
				AudioSource.PlayClipAtPoint(hit, transform.position);
			}
		}
	}
}
