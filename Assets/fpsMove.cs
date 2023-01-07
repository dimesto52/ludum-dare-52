using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsMove : MonoBehaviour
{

    public float speed = 10.0f;
    public Vector3 mouspos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        mouspos += new Vector3(Input.GetAxis("Mouse X"), 0, 0);

        transform.rotation = Quaternion.Euler( 0,mouspos.x, 0);

        Debug.DrawLine(transform.position, transform.position+ Camera.main.transform.forward);

        transform.position += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime* speed;
        transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime* speed;
    }
}
