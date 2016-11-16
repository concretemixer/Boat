using UnityEngine;
using System.Collections;
using System.IO;

public class Boat : MonoBehaviour {

	// Use this for initialization
    public GameObject boat;
    public GameObject target;
    public GameObject turret;
    public GameObject realTarget;

	void Start () {
	
	}

    static int shotNum = 0;		
	// Update is called once per frame
    void Update () {
        float v = GetComponent<Rigidbody>().velocity.magnitude;
        float va = GetComponent<Rigidbody>().angularVelocity.y;

        boat.transform.localRotation = Quaternion.Euler(new Vector3( Mathf.Clamp(v*0.5f,-5,5), 0, Mathf.Clamp(va*-10.0f,-10,10)));

        Vector3 p = target.transform.position;
        p.y = turret.transform.position.y;

        Vector3 localTarget = -(target.transform.position - transform.position);
        localTarget.y = -turret.transform.position.y;
        Quaternion t = Quaternion.LookRotation(localTarget);
               
        turret.transform.rotation = Quaternion.RotateTowards(turret.transform.rotation, t, 50*Time.deltaTime);

        Vector3 pp = turret.transform.rotation * (-Vector3.forward * (target.transform.position - turret.transform.position).magnitude);
        pp.y = target.transform.position.y;
        realTarget.transform.position = pp;

       

			if (Input.GetKeyDown(KeyCode.F4))
			{

				string filename = @"d:\--\shot" + shotNum.ToString() + ".png";
				while (File.Exists(filename))
				{
					shotNum++;
					filename = @"d:\--\shot" + shotNum.ToString() + ".png";                    
				}

				Application.CaptureScreenshot(filename);
				shotNum++;
			}

    }

	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * -20);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 10);
        }

        float v = GetComponent<Rigidbody>().velocity.magnitude;

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * -0.05f * v);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * 0.05f * v);
         
        }

	}
}
