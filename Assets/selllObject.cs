using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selllObject : MonoBehaviour
{
    public GameObject objtosell;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (money.wallet.Value < 5)
            obj.transform.position = transform.position;

        else if (obj == pkableObject.lastPikable)
        {

            money.wallet.Value -= 5;
            obj = Instantiate(objtosell);
        }
    }
}
