using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChastersUpgrade : MonoBehaviour
{
    // Обьявление переменных
    public Button 
        attackGrade,
        healthGrade;
    public Text 
        attackGradeText,
        healthGradeText,
        attackLevelText,
        healthLevelText;
    public static double
        priceGrade,
        hp_priceGrade,
        as_priceGrade;
    public static int 
        levelGradeKOEF=1, 
        hp_levelGradeKOEF=1,
        as_levelGradeKOEF;
    //
    void Start()
    {
        variableDeclaration();
    }
    void variableDeclaration()
    {
        attackGrade.onClick.AddListener(TaskOnClickAttackGrade);
        healthGrade.onClick.AddListener(TaskOnClickHealthGrade);
        healthLevelText.text = "" + hp_levelGradeKOEF;
        attackLevelText.text = "" + levelGradeKOEF;
        attackGradeText.text = priceGrade + " gold";
        healthGradeText.text = hp_priceGrade + " gold";
    }
    void TaskOnClickAttackGrade()
    {
        priceGrade = 1 + levelGradeKOEF * 1.8;
        if (CurrencyController.gold >= priceGrade)
        {
            DamageSystem.Wardamage += (1 +levelGradeKOEF);
            levelGradeKOEF++;
            attackGradeText.text = priceGrade + " gold";
            attackLevelText.text = ""+levelGradeKOEF;
            CurrencyController.gold -= priceGrade;
        }
    }
    void TaskOnClickHealthGrade()
    {
        hp_priceGrade = 1 + hp_levelGradeKOEF * 1.8;
        if (CurrencyController.gold >= hp_priceGrade)
        {
            DamageSystem.Warhp += (1 + hp_levelGradeKOEF);
            hp_levelGradeKOEF++;
            healthGradeText.text = hp_priceGrade + " gold";
            healthLevelText.text = "" + hp_levelGradeKOEF;
            CurrencyController.gold -= hp_priceGrade;
        }
    }
    void ScruptTaskOnClickAttackGrade()
    {
        if (CurrencyController.gold >= as_priceGrade)
        {
           //донатная валюта
        }
    }
}
