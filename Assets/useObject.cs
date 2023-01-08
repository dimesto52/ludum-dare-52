using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class useObject : MonoBehaviour
{
    public UnityEvent use;
    public UnityEvent unuse;

    public string type;

    public static useObject inuse = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pkableObject.lastPikable != null)
        if (pkableObject.lastPikable.gameObject == gameObject)
        {

            if (Input.GetMouseButtonDown(1))
            {
                inuse = this;
                use.Invoke();
            }

            if (Input.GetMouseButtonUp(1))
            {
                inuse = null;
                unuse.Invoke();
            }
        }
    }
}
