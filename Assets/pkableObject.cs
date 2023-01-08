using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkableObject : MonoBehaviour
{
    public static GameObject lastPikable = null;

    public Vector3 posInHand = Vector3.zero;
    public Vector3 rotateInHand = Vector3.zero;

    public bool fisrtpick = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (lastPikable == null)
        {

            lastPikable = this.gameObject;

            this.GetComponent<Rigidbody>().useGravity = false;

            Debug.Log("pick" + lastPikable.name);
        }
        else
        {
            Debug.Log("pick" + lastPikable.name);
        }
    }
}
