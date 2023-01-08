using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pkableObject.lastPikable != null)
        {
            if(Vector3.Distance(transform.position, pkableObject.lastPikable.transform.position) > 4.0f)
            {
                pkableObject.lastPikable = null;
            }
            else
            {

                Vector3 posInHand = pkableObject.lastPikable.GetComponent<pkableObject>().posInHand;
                pkableObject.lastPikable.transform.position = transform.position + Camera.main.transform.forward + posInHand;
                pkableObject.lastPikable.transform.LookAt(transform.position + Camera.main.transform.forward * 2 + posInHand);
                pkableObject.lastPikable.transform.Rotate(pkableObject.lastPikable.GetComponent<pkableObject>().rotateInHand);

                if (Input.GetMouseButtonUp(0))
                {
                    pkableObject.lastPikable.GetComponent<Rigidbody>().useGravity = true;
                    pkableObject.lastPikable = null;
                }
            }
        }
    }
}
