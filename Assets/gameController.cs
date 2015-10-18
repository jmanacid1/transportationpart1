using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {
	int numCubes = 16;
	public GameObject cubePrefab;
	public static GameObject [] allCubes;
		
	// Use this for initialization
	void Start () {
		allCubes = new GameObject[numCubes];
		for (int i = 0; i < numCubes; i++) {
			allCubes [i] = (GameObject)Instantiate(cubePrefab, new Vector3(i*2, 0, 0), Quaternion.identity);
		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
