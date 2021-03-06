﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Sensitivity = 1f;
    private Transform cameraTransform = default;
    private float speed ;
    private float yawn = 0.0f;
    private float pitch = 0.0f;
    private Transform playerTransform;
    // Start is called before the first frame update
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        speed = 0.05f;
        cameraTransform = transform;
        yawn = 0.0f;
        pitch = 0.0f;
        playerTransform = transform;      
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        HandleMovement();
        HandleCameraMovement();
    }

   private void HandleMovement(){
        Vector3 currentPosition = playerTransform.position;
            Vector3 deltaPosition = (
                playerTransform.right * Input.GetAxis("Horizontal")
                + playerTransform.forward * Input.GetAxis("Vertical")
            ) * speed;
            deltaPosition.y = 0f;
            playerTransform.position = currentPosition + deltaPosition;
    }

    private void HandleCameraMovement() {
            yawn += Input.GetAxis("Mouse X") * Sensitivity;
            pitch -= Input.GetAxis("Mouse Y") * Sensitivity;
            pitch = Mathf.Clamp(pitch, -90f, 90f);
            transform.eulerAngles = new Vector3(pitch, yawn, 0f);
        }
}
