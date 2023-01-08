using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class grow : MonoBehaviour
{

    public float water = 0;
    public float growCount = 0;
    public float growSpeed = 1;
    public float growAmount = 100;

    public UnityEvent fullgrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (growCount < 1)
        {
            if (water > 0)
            {
                growCount += Time.deltaTime * growSpeed;
                water -= Time.deltaTime;
            }

            if (growCount >= 1)
            {
                growCount = 1;
                fullgrow.Invoke();
            }

            transform.localScale = Vector3.one * growAmount * growCount;
        }
    }

}
