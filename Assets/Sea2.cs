using UnityEngine;
using System.Collections;

public class Sea2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    Vector2 ofs = Vector2.zero;
    Vector2 ofs2 = Vector2.zero;
	// Update is called once per frame
	void Update () {

        GetComponent<MeshRenderer>().sharedMaterial.EnableKeyword("_ALPHABLEND_ON");
        GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_DstBlend",1.0f);
        GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_SrcBlend",1.0f);
        GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_ZWrite", 0.0f);        
        
       // GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_DetailNormalMapScale", 0.2f+0.1f*Mathf.Sin(Time.realtimeSinceStartup));
        //GetComponent<MeshRenderer>().sharedMaterial.SetFloat("_BumpScale", 0.2f+0.1f*Mathf.Cos(Time.realtimeSinceStartup+1));
    }
}
