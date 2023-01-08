using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harvestFruit : MonoBehaviour
{

    public fruitGrow plant;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {

        Debug.Log("over : " + gameObject.name);
        if (useObject.inuse != null)
        {
            Debug.Log("use : " + useObject.inuse.type);
            if (useObject.inuse.type == "knif")
            {
                Debug.Log("use : " + useObject.inuse.type + " on "+ gameObject.name);
                plant.Startgrow();
                this.GetComponent<pkableObject>().enabled = true;
                this.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
