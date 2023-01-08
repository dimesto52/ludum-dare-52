using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCamera : MonoBehaviour
{

    public bool lockMouse = false;

    public Vector3 mouspos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
            if(Cursor.lockState == CursorLockMode.Locked)
                 Cursor.lockState = CursorLockMode.None;
            else Cursor.lockState = CursorLockMode.Locked;


        mouspos += new Vector3(0, -Input.GetAxis("Mouse Y"),0);

        mouspos.y = Mathf.Clamp(mouspos.y, -45, 45);

        transform.localRotation = Quaternion.Euler(mouspos.y, 0, 0);
        

    }
}
