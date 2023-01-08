using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneydraw : MonoBehaviour
{
    Text t;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
        money.wallet.upMoney += UpdateText;
        UpdateText(money.wallet.Value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateText( int i )
    {
        t.text = i.ToString() + " $";
    }
}
