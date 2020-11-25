using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartFight : MonoBehaviour
{
    public GameObject Camera;
    public static bool StartFighter = false;
    public static bool ButtonOn = false;
    public static bool fightStart = false;
    public Button fight;
    // Start is called before the first frame update
    void Start()
    {
        fight.onClick.AddListener(TaskOnClickFight);
    }

    // Update is called once per frame
    void TaskOnClickFight()
    {
        ButtonOn = true;
        Camera.transform.position = new Vector3(-59.3f,-0.28f, -6f);
        if(fightStart==false)
        {
            WarriorAttack.findstate = true;
            fightStart = true;

        }
    }
}
