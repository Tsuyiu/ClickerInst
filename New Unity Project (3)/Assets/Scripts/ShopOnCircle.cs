using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopOnCircle : MonoBehaviour
{
    public GameObject Miner,
        Miner2,
        Miner3,
        circle;
    private double ThisGold;
    private bool 
        BuyStatus,
        BuyStatus2,
        BuyStatus3;
    Vector3 SpawnPos;
     void Start()
    {
        SpawnPos = circle.transform.position+new Vector3(0,.2f,-1f);
    }

    void OnMouseDown()
    {
        BuyStatus = MinerBuyerController.buyStatusMiner1;
        BuyStatus2 = MinerBuyerController.buyStatusMiner2;
        BuyStatus3 = MinerBuyerController.buyStatusMiner3;
        if (BuyStatus)
        {
            ThisGold = CurrencyController.iron;
            if (ThisGold >= 10)
            {
                Instantiate(Miner, SpawnPos, Quaternion.identity);
                CurrencyController.gold -= 10;
                MinerBuyerController.buyStatusMiner1 = false;
                ThisGold = CurrencyController.gold;

            }
        }
        if (BuyStatus2)
        {
            ThisGold = CurrencyController.iron;
            if (ThisGold >= 100)
            {
                Instantiate(Miner2, SpawnPos, Quaternion.identity);
                CurrencyController.gold -= 100;
                MinerBuyerController.buyStatusMiner2 = false;
                ThisGold = CurrencyController.gold;

            }
        }
        if (BuyStatus3)
        {
            ThisGold = CurrencyController.gold;
            if (ThisGold >= 7000)
            {
                Instantiate(Miner3, SpawnPos, Quaternion.identity);
                CurrencyController.gold -= 7000;
                MinerBuyerController.buyStatusMiner3 = false;
                ThisGold = CurrencyController.gold;

            }
        }
    }
}
