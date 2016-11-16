using UnityEngine;
using System.Collections;

public class Reflect : MonoBehaviour {

	// Use this for initialization
    ReflectionProbe probe;

    void Awake()
    {
        probe = GetComponent<ReflectionProbe>();
    }

    void Update()
    {

        probe.RenderProbe();
    }
}
