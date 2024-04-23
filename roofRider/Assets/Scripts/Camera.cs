using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Camera : MonoBehaviour
{


    public float mouseSensitivity = 100f;
    private float xRotation = 0f;

    public Transform playerBody;

    public static UnityEngine.Camera main;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * (mouseSensitivity * 10) * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * (mouseSensitivity * 10) * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mousex);
    }
}
