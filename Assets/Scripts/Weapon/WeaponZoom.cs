using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 30f;
    [SerializeField] float mouseSensitivityZoomedIn = 1.5f;
    [SerializeField] float mouseSensitivityZoomedOut = 3f;
    
    
    bool zoomedInToggle = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = mouseSensitivityZoomedIn;
        fpsController.mouseLook.YSensitivity = mouseSensitivityZoomedIn;
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = mouseSensitivityZoomedOut;
        fpsController.mouseLook.YSensitivity = mouseSensitivityZoomedOut;
    }

    void OnDisable() 
    {
        ZoomOut();
    }
}
