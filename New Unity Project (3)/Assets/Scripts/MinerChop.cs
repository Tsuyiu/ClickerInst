using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinerChop : MonoBehaviour
{
    public int FarmGoldMiner;
    public Item Pickaxe = new Item();
    bool chopStatic=true;
    private double 
        Iron;
    private float
        ChopTime = 1f;
    //public Sprite sprite;
   // public static Sprite[] spriteList;
    void Start()
    {
        DefoltPickaxe();
        ItemList.variableDeclaration();
    }

    // Update is called once per frame
    void Update()
    {      
        if(chopStatic)
        {
            StartCoroutine(Chop());
        }
    }
    IEnumerator Chop()
    {
        chopStatic = false;
        ChopTime = (1f / Pickaxe.ChopSpeed);
        yield return new WaitForSeconds(ChopTime);
        float vari;
        vari = 1 * FarmGoldMiner;
        CurrencyController.iron+=vari;
        chopStatic = true;
    }
    public void DefoltPickaxe()
    {
        Pickaxe.ChopSpeed = 1;
        Pickaxe.id = 0;
        Pickaxe.name = "Pickaxe";
       // Pickaxe.img = spriteList[0];
    }
}
 [System.Serializable]

 public class Item
{
    public int id;
    public string name;
    //public 
     //   Sprite img;
    public float ChopSpeed;
}

[System.Serializable]
public static class ItemList
{
    //Запись для замены айтема Pickaxe = ItemList.newPickaxe;
    public static Item Pickaxe1=new Item();

    public static void variableDeclaration()
    {
        Pickaxe1State();
    }
    public static void Pickaxe1State()
    {
        Pickaxe1.ChopSpeed = 10;
        Pickaxe1.id = 1;
        Pickaxe1.name = "newPickaxe";
        //newPickaxe.img = MinerChop.spriteList[0];
    }
}