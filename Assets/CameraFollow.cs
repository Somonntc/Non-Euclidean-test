using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform cameraA;
    [SerializeField] private Transform portalA;
    [SerializeField] private Transform portalB;
    private float offset = 0.0f;
    
    // Start is called before the first frame update
    void Awake()
    {
        transform.rotation = cameraA.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetFromPortal = cameraA.position - portalB.position;
        transform.position = portalA.position + playerOffsetFromPortal;
        print(playerOffsetFromPortal);

        float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portalA.rotation, portalB.rotation);

        Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationalDifference * cameraA.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }
}
