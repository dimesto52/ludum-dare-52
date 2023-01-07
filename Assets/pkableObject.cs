using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkableObject : MonoBehaviour
{
    public static GameObject lastPikable = null;

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
    }
}
