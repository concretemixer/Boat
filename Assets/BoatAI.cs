using UnityEngine;
using System.Collections;

public class BoatAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * -20);
	}
}
