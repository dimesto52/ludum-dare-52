using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedDetect : MonoBehaviour
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
        seedInfo info = other.GetComponent<seedInfo>();

        if (info != null)
        {

            Debug.Log("seed : " + info.gameObject.name);

            GameObject go = Instantiate(info.plante);
            go.transform.position = transform.parent.position;

            transform.parent.GetComponent<waterPot>().plant = go.GetComponent<grow>();

            Destroy(info.gameObject);
        }
    }

}
