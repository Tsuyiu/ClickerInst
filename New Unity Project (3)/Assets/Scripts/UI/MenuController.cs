using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button 
        floors,
        MinerShop,
        Button3,
        Button4,
        Button5,
        Button6,
        Button7,
        Button8;
    private GameObject floorsWindow,
        window;
    public GameObject[] MenuWindows; //1-floors ................
    void Start()
    {
        floors.onClick.AddListener(TaskOnClickFloors);
        MinerShop.onClick.AddListener(TaskOnClickMinerShop);
        Button3.onClick.AddListener(TaskOnClickButton3);
        Button4.onClick.AddListener(TaskOnClickButton4);
        Button5.onClick.AddListener(TaskOnClickButton5);
        Button6.onClick.AddListener(TaskOnClickButton6);
        Button7.onClick.AddListener(TaskOnClickButton7);
        Button8.onClick.AddListener(TaskOnClickButton8);

    }
    void TaskOnClickFloors()
    {
        CheckWindow(0);
    }
    void TaskOnClickMinerShop()
    {
        CheckWindow(1);
    }
    void TaskOnClickButton3()
    {
        CheckWindow(2);
    }
    void TaskOnClickButton4()
    {
        CheckWindow(3);
    }
    void TaskOnClickButton5()
    {
        CheckWindow(4);
    }
    void TaskOnClickButton6()
    {
        CheckWindow(5);
    }
    void TaskOnClickButton7()
    {
        CheckWindow(6);
    }
    void TaskOnClickButton8()
    {
        CheckWindow(7);
    }
    void CheckWindow(int number)
    {
        for (int i = 0; i < MenuWindows.Length; i++)
        {
            window = MenuWindows[i];
            window.transform.localScale = new Vector3(0f, 0f, 0f);
            if (i == number)
            {
                window.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
    }
}
