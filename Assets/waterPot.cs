using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterPot : MonoBehaviour
{

    public grow plant;
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
            if (useObject.inuse.type == "wateringCan")
            {
                if(plant != null)
                    plant.water = 0.5f;
            }
        }
    }
}
