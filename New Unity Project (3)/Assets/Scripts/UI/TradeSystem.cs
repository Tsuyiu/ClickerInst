using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TradeSystem : MonoBehaviour
{
    public Button Trade,
        Trade1,
        Trade2,
        Trade3;
    double irn;
    void Start()
    {
        Trade.onClick.AddListener(TradeOnClick);
        Trade1.onClick.AddListener(TradeOnClick1);
        Trade2.onClick.AddListener(TradeOnClick2);
        Trade3.onClick.AddListener(TradeOnClick3);
    }
    void TradeOnClick()
    {
        if (CurrencyController.iron >= 100)
        {
            CurrencyController.gold++;
            CurrencyController.iron -= 100;
        }
    }
    void TradeOnClick1()
    {
        if (CurrencyController.iron >= 10000)
        {
            CurrencyController.gold += 100;
            CurrencyController.iron -= 10000;
        }
    }
    void TradeOnClick2()
    {
        if (CurrencyController.iron >= 1000000)
        {
            CurrencyController.gold += 10000;
            CurrencyController.iron -= 1000000;
        }
    }
    void TradeOnClick3()
    {
        if (CurrencyController.iron >= 100000000)
        {
            CurrencyController.gold += 1000000;
            CurrencyController.iron -= 100000000;
        }
    }
}
