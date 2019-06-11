using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanDepth : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        if (!cam)
            cam = GetComponent<Camera>();

        if (cam)
            cam.depthTextureMode = DepthTextureMode.Depth;
    }


}
