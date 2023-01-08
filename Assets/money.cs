using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class money 
{

    public static money wallet = new money();
    public Action<int> upMoney;

    int _value = 5;

    public int Value
    {
        get { return _value; }
        set 
        { 
            _value = value;
            upMoney?.Invoke(_value);
        }
    }

}
