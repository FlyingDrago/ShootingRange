using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByMouse : MonoBehaviour
{

    public float anglePerSecond;
    public Transform cameraHolder;
    public float minPitch;
    public float maxPitch;

    private float pitch;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        UpdateYaw();
        UpdatePitch();
        float mousex=Input.GetAxis("Mouse X");
        float mousey=Input.GetAxis("Mouse Y");
        float yaw=mousex*anglePerSecond*Time.deltaTime;
        transform.Rotate(0,yaw,0);
    }
    private void UpdateYaw()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float deltaYaw = mouseX * anglePerSecond * Time.deltaTime;
        transform.Rotate(0, deltaYaw, 0);
    }
    private void UpdatePitch()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        float pitchDelta = -mouseY * anglePerSecond*Time.deltaTime;
        pitch = Mathf.Clamp(pitch + pitchDelta, minPitch, maxPitch);
        cameraHolder.localEulerAngles = new Vector3(pitch, 0, 0);
    }
    
}
