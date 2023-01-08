using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        valueObject info = other.GetComponent<valueObject>();

        if (info != null)
        {

            Debug.Log("vale object : " + info.gameObject.name);

            money.wallet.Value += 10;

            Destroy(info.gameObject);
        }
    }
}
