using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FloorController : MonoBehaviour
{
    public Button 
        floor1,
        floor2,
        buy2floor,
        buy3floor,
        outpost1;
    public GameObject Camera;
    private bool statusbuy2floor=false, statusbuy3floor=false;
    void Start()
    {
        floor1.onClick.AddListener(TaskOnClickFloor1);
        floor2.onClick.AddListener(TaskOnClickFloor2);
        outpost1.onClick.AddListener(TaskOnClickOutpost1);
        buy2floor.onClick.AddListener(TaskOnBuy2Floor);
        buy3floor.onClick.AddListener(TaskOnBuy3Floor);
    }
    void TaskOnClickFloor1()
    {
        Camera.transform.position = new Vector3(-12.2f,-1.3f,-6f);
    }

    void TaskOnClickFloor2()
    {
        if (statusbuy2floor == true)
        {
            Camera.transform.position = new Vector3(-17.94f, -1.3f, -6f);
        }
    }

    void TaskOnClickOutpost1()
    {
        if (statusbuy3floor == true)
        {
            Camera.transform.position = new Vector3(-12.2f, 2.1f, -6f);
        }
    }
    void TaskOnBuy2Floor()
    {
        if (CurrencyController.gold >= 1000 && statusbuy2floor==false)
        {
            statusbuy2floor = true;
            CurrencyController.gold -= 1000;
        }
    }
    void TaskOnBuy3Floor()
    {
        if (CurrencyController.gold >= 10000 && statusbuy3floor == false)
        {
            statusbuy3floor = true;
            CurrencyController.gold -= 10000;
        }
    }
}
