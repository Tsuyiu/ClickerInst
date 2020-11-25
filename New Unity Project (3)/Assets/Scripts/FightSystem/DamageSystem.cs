using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DamageSystem : MonoBehaviour
{
    public static UnitsState Warr = new UnitsState();
    public static bool
        warWin = false,
        enemWin = false;
    public static int Warhp = 30;
    public static int Wardamage = 15;
    public static int Enemhp;
    public static int Enemdamage;
    public static int trigger=0;//OnTriggerEnter2D срабатывает дважды
    void Start()
    {
        Warr.hp = Warhp;
        Warr.damage = Wardamage;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (trigger == 2)
            {
                Debug.Log("Warhp " + Warr.hp);
                EnemyDamage.TakeEnemyDamage(Warr.damage);
                Debug.Log("Warhp " + Warr.hp);
                trigger = 0;
                if (Warr.hp <= 0)
                {
                    EndFight();
                }
            }
            else if(trigger<2)
            {
                trigger++;
            }

        }
    }
    public static void TakeDamage(int Damage)
    {
        Warr.hp -= Damage;
        
    }
    public static void EndFight()
    {
        WarriorAttack.findstate = false;
        if (Warr.hp <= 0 && warWin != true)
        {
            enemWin = true;
            Debug.Log("Enemy win");
        }
        if (EnemyDamage.enem.hp <= 0 && enemWin != true)
        {
            warWin = true;
            Debug.Log("Warriors win");
        }
    }
}
public class UnitsState
{
    public int hp;
    public int damage;
}