using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {
	


	void OnMouseDown () {
		foreach (GameObject position in gameController.allCubes) {
			position.GetComponent<Renderer> ().material.color = Color.white;
		}
		GetComponent<Renderer> ().material.color = Color.red;
	}

}
