using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelTexture : MonoBehaviour
{
    public Camera cameraA;
    public Material cameraMatA;

    public Camera cameraB;
    public Material cameraMatB;
    public Camera cameraC;
    public Material cameraMatC;
    public Camera cameraD;
    public Material cameraMatD;

    void Start()
    {
        if(cameraA.targetTexture != null){
            cameraA.targetTexture.Release();
        }
        cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatA.mainTexture = cameraA.targetTexture;

        if(cameraB.targetTexture != null){
            cameraB.targetTexture.Release();
        }
        cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatB.mainTexture = cameraB.targetTexture;

        if(cameraC.targetTexture != null){
            cameraC.targetTexture.Release();
        }
        cameraC.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatC.mainTexture = cameraC.targetTexture;

        if(cameraD.targetTexture != null){
            cameraD.targetTexture.Release();
        }
        cameraD.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatD.mainTexture = cameraD.targetTexture;
    }
}
