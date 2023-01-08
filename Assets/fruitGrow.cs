using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitGrow : MonoBehaviour
{

    public grow plant;

    public GameObject fruit;
    public GameObject fullfruit;


    public float growCount = 0;
    public float growSpeed = 1;
    public float growAmount = 100;

    GameObject ingrow = null;

    public void Startgrow()
    {
        growCount = 0;
        ingrow = Instantiate(fruit);
        ingrow.transform.position = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        if(ingrow != null)
            ingrow.transform.position = transform.position;

        if (growCount < 1 && ingrow != null)
        {
            if (plant.water > 0)
            {
                growCount += Time.deltaTime * growSpeed;
                plant.water -= Time.deltaTime;
            }

            if (growCount >= 1)
            {
                growCount = 1;

                Destroy(ingrow);
                ingrow = Instantiate(fullfruit);
                ingrow.transform.position = transform.position;

                ingrow.GetComponent<harvestFruit>().plant = this;
            }
            else
                ingrow.transform.localScale = Vector3.one * growAmount * growCount;
        }
    }
}
