using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour {

    public GameObject anchor;
    public GameObject seaPlane;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = anchor.transform.position;
        UpdateSeaMaterial();
	}

    Vector2 ofs = Vector2.zero;
    Vector2 ofs2 = Vector2.zero;

    void UpdateSeaMaterial() {

        // return;
        Vector2 mainOffset = Vector2.zero;

        mainOffset.x = -anchor.transform.position.x / 150.0f;
        mainOffset.y = -anchor.transform.position.z / 150.0f;

        Vector2 o = ofs;
        o.x = Mathf.Ceil(ofs.x * 64) / 64;
        o.y = Mathf.Ceil(ofs.x * 64) / 64;

        seaPlane.GetComponent<MeshRenderer>().sharedMaterial.SetTextureOffset("_DetailAlbedoMap", mainOffset+ofs);

        o.x = Mathf.Ceil(ofs2.x * 64) / 64;
        o.y = Mathf.Ceil(ofs2.x * 64) / 64;

        seaPlane.GetComponent<MeshRenderer>().sharedMaterial.SetTextureOffset("_MainTex", mainOffset+ofs2);
        // GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_DetailNormalMapScale", 0.2f+0.1f*Mathf.Sin(Time.realtimeSinceStartup));
        //GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_BumpScale", 0.2f+0.1f*Mathf.Cos(Time.realtimeSinceStartup+1));


        ofs.x += Mathf.Cos(Time.realtimeSinceStartup)*Time.deltaTime*0.01f;
        ofs.y += Mathf.Sin(Time.realtimeSinceStartup) * Time.deltaTime * 0.01f;
        ofs2.x += Mathf.Sin(Time.realtimeSinceStartup) * Time.deltaTime * 0.02f;
        ofs2.y += Mathf.Cos(Time.realtimeSinceStartup) * Time.deltaTime * 0.02f;
    }
}
