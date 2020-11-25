using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;
using UnityEngine.UI;

// Сделать обменник с iron на голд +- 1к1000
public class CurrencyController : MonoBehaviour
{
    public static double iron=20;
    public static double gold=10000;
    //------------------------------------------------------------------
    public Text
        Gold,
        Iron;
    bool status = true;
    public double
        hIron,
        thIron,
        hGold,
        thGold;
    void Update()
    {
        
        if(status)
        {
            StartCoroutine(UpdateGoldIron());
        }
    }
    IEnumerator UpdateGoldIron()
    {
        status = false;
        yield return new WaitForSeconds(1);
        Gold.text = " " + gold;
        Iron.text = " " + iron;
        hIron = iron / 1000;
        thIron = iron / 1000000;
        hGold = gold / 1000;
        thGold = gold / 1000000;
        ValueEnumerator();
        if (iron >= 1000 && iron < 1000000)
        {
            Iron.text = hIron + "k";
        }
        else if(iron >= 1000000)
        {
            Iron.text = (iron / 1000000) + "kk";
        }
        if (gold >= 1000 && gold < 1000000)
        {
            Gold.text = (gold / 1000)  + "k";
        }
        else if(gold >= 1000000)
        {
            Gold.text = (gold / 1000000) + "kk";
        }
        status = true;
    }
    void ValueEnumerator()
    {      
        if(hIron<=10 && hIron>1)
        {
            hIron -= (hIron / 1);  //
        }
        else if(hIron>10 && hIron<=100)
        {
            hIron -= hIron/1;
        }
        else if (hIron > 100 && hIron <= 1000)
        {
            hIron -= hIron / 1;
        }
        else if (hIron > 1000 && hIron <= 10000)
        {
            hIron -= hIron / 1;
        }
        else if (hIron > 10000 && hIron <= 100000)
        {
            hIron -= hIron / 1;
        }
        else if (hIron > 100000 && hIron <= 1000000)
        {
            hIron -= hIron / 1;
        }
    }
}
