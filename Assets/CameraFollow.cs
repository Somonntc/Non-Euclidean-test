using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform MainCamera;
    [SerializeField] private bool follow = true;
    private float offset = 0.0f;
    
    // Start is called before the first frame update
    void Awake()
    {
        offset = Mathf.Abs(MainCamera.position.z - transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(follow){
            transform.position = new Vector3(MainCamera.position.x, MainCamera.position.y, MainCamera.position.z-offset);
            transform.rotation = MainCamera.transform.rotation;
        }
        
    }
}
