using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 1 floor (xPos=-13 (11), y=0.9 (0))
/// </summary>
public class MinerBuyerController : MonoBehaviour
{
    public GameObject[] circles;
    public Button 
        BuyMiner1,
        BuyMiner2,
        BuyMiner3;
    public static bool buyStatusMiner1 = false;
    public static bool buyStatusMiner2 = false;
    public static bool buyStatusMiner3 = false;
    private float
        yUp = .45f,
        xPos,
        yPos;
    public double iron;
    Vector3 
        spawnPos;
    private GameObject circle;

    void Start()
    {
        CreateCricles();
        SettingsBoard();
    }
    void CreateCricles()
    {
            for (yPos = -.9f; yPos < 0; yPos += yUp)
            {
                for (xPos = -13; xPos <= -11; xPos++)
                {
                    spawnPos = new Vector3(xPos, yPos,-3f);
                    circle = circles[0];
                    Instantiate(circle, spawnPos, Quaternion.identity);
                }
            }
        for (yPos = -.9f; yPos < 0f; yPos += yUp)
        {
            for (xPos = -19f; xPos <= -17f; xPos++)
            {
                spawnPos = new Vector3(xPos, yPos, -3f);
                circle = circles[0];                        // В массиве кругов будут разные и на разных этажах будет менятся индекс( в будущем)
                Instantiate(circle, spawnPos, Quaternion.identity);
            }
        }
        for (yPos = 2.5f; yPos < 3.1; yPos += yUp)
        {
            for (xPos = -13; xPos <= -11; xPos++)
            {
                spawnPos = new Vector3(xPos, yPos, -3f);
                circle = circles[0];
                Instantiate(circle, spawnPos, Quaternion.identity);
            }
        }
    }
    void SettingsBoard()
    {
        BuyMiner1.onClick.AddListener(TaskOnClickBuyMiner1);
        BuyMiner2.onClick.AddListener(TaskOnClickBuyMiner2);
        BuyMiner3.onClick.AddListener(TaskOnClickBuyMiner3);
    }

    void TaskOnClickBuyMiner1()
    {
        buyStatusMiner1 = true;
    }
    void TaskOnClickBuyMiner2()
    {
        buyStatusMiner2 = true;
    }
    void TaskOnClickBuyMiner3()
    {
        buyStatusMiner3 = true;
    }
}
