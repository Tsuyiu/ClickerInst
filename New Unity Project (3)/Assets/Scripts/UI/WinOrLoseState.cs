using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinOrLoseState : MonoBehaviour
{
    public Text levelText;
    public static int level=1;
    public bool UpState = true;
    // Start is called before the first frame update
    void Start()
    {
        levelText.transform.localScale = new Vector3(0f, 0f, 0f);
        levelText.text = "Level: " + level;
    }
    void Update()
    {
        if(UpState==true)
        {
            StartCoroutine(GameCor());
        }
    }
   IEnumerator GameCor()
    {
        UpState = false;
        if(StartFight.ButtonOn)
        {
            levelText.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if(DamageSystem.warWin)
        {
            level++;
            DamageSystem.Warr.hp = DamageSystem.Warhp;
            DamageSystem.Warr.damage = DamageSystem.Wardamage;
            EnemyDamage.enem.hp = (EnemyDamage.Enemhp * (WinOrLoseState.level * 2));
            EnemyDamage.enem.damage = (EnemyDamage.Enemdamage * (WinOrLoseState.level * 2));
            levelText.text = "Level: "+level;
            DamageSystem.warWin = false;
        }
        else if(DamageSystem.enemWin)
        {
            level -= 5;
            DamageSystem.Warr.hp = DamageSystem.Warhp;
            DamageSystem.Warr.damage = DamageSystem.Wardamage;
            EnemyDamage.enem.hp = (EnemyDamage.Enemhp * (WinOrLoseState.level * 2));
            EnemyDamage.enem.damage = (EnemyDamage.Enemdamage * (WinOrLoseState.level * 2));
            levelText.text = "Level: " + level;
            DamageSystem.enemWin = false;
        }
        yield return new WaitForSeconds(0.01f);
        UpState = true;
    }
}
