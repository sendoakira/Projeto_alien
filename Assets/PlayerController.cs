using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		Vector3 movimento = new Vector3 (horizontal * 5 * Time.deltaTime, 0, 0);
		transform.Translate (movimento);

	}
}
