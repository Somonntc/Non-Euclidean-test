using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform otherPortalTransform;
    [SerializeField] private Transform mainCamera;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        mainCamera.position = otherPortalTransform.position;
        print("Transform teleportation");
    }
}
