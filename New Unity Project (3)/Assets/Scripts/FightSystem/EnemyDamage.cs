using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public static bool attackBoll=true,
        CheckEndLevel=false;
    public static UnitsState enem=new UnitsState();
    public static int Enemhp = 3;
    public static int Enemdamage = 1;
    public static int triger; //OnTriggerEnter2D срабатывает дважды
    void Start()
    {
        enem.hp = Enemhp;
        enem.damage = Enemdamage;
    }
    void Update()
    {
        if (CheckEndLevel)
        {
            enem.hp = Enemhp;
            enem.damage = Enemdamage;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Warrior")
        {
            if (triger == 2)
            {
                 Debug.Log("enemhp " + enem.hp);
                DamageSystem.TakeDamage(enem.damage);
                Debug.Log("enemhp " + enem.hp);
                triger = 0;
                if (enem.hp <= 0)
                {
                    CheckEndLevel = true;
                    DamageSystem.EndFight();
                    CheckEndLevel = false;
                }
            }
            else if(triger<2)
            {
                triger++;
            }

        }
    }
    public static void TakeEnemyDamage(int Damage)
    {
            enem.hp -= Damage;
    }
}
