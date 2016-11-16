using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    Plane ground = new Plane(Vector3.up, Vector3.zero);

    float targetAngle = 0;
    float angle = 0;
    Vector3 mouse;
    public GameObject target;

	// Use this for initialization
	void Start () {
        mouse = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
        transform.localRotation = Quaternion.Euler(0, angle, 0);
        float dm = mouse.x - Input.mousePosition.x;
        mouse = Input.mousePosition;
        targetAngle += -0.2f*dm;

        angle = Mathf.LerpAngle(angle, targetAngle, Time.deltaTime * 5.0f);

        Camera camera = Camera.main;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        float rayDistance;
        if (ground.Raycast (ray, out rayDistance)) {
            Vector3 touchGround = ray.origin + ray.direction * rayDistance;

            target.transform.position = touchGround;
        }
	}
}
