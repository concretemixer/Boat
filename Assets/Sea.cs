using UnityEngine;
using System.Collections;

public class Sea : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    Vector2 ofs = Vector2.zero;
    Vector2 ofs2 = Vector2.zero;
	// Update is called once per frame
	void Update () {
      
       // return;
        Vector2 o = ofs;
        o.x = Mathf.Ceil(ofs.x * 64) / 64;
        o.y = Mathf.Ceil(ofs.x * 64) / 64;

        GetComponent<MeshRenderer>().sharedMaterial.SetTextureOffset("_DetailAlbedoMap", ofs);

        o.x = Mathf.Ceil(ofs2.x * 64) / 64;
        o.y = Mathf.Ceil(ofs2.x * 64) / 64;

        GetComponent<MeshRenderer>().sharedMaterial.SetTextureOffset("_MainTex", ofs2);
       // GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_DetailNormalMapScale", 0.2f+0.1f*Mathf.Sin(Time.realtimeSinceStartup));
        //GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_BumpScale", 0.2f+0.1f*Mathf.Cos(Time.realtimeSinceStartup+1));

       
        ofs.x += Mathf.Cos(Time.realtimeSinceStartup)*Time.deltaTime*0.05f;
        ofs.y += Mathf.Sin(Time.realtimeSinceStartup) * Time.deltaTime * 0.05f;
        ofs2.x += Mathf.Sin(Time.realtimeSinceStartup) * Time.deltaTime * 0.05f;
        ofs2.y += Mathf.Cos(Time.realtimeSinceStartup) * Time.deltaTime * 0.05f;
    }
}
