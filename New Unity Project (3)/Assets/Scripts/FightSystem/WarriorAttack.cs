using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;

public class WarriorAttack : MonoBehaviour
{
    public int 
        enemyTarget,
        warriorTarget;
    public float attackSpeed = 1f,
        gameSpeed = 2f;
    private Vector3 
        startPos;
    //public GameObject warrior;
    public static bool findstate = false;
    List<GameObject> enemylist = new List<GameObject>();
    List<GameObject> warriorlist = new List<GameObject>();
    void Update()
    {
        if(findstate)
        StartCoroutine(FindEnemy());
    }

    void FindTarget()
    {
      enemyTarget = Random.Range(0, 3);
      warriorTarget = Random.Range(0, 3);
      startPos = enemylist[enemyTarget].transform.position;
      enemylist[enemyTarget].transform.position = warriorlist[warriorTarget].transform.position + new Vector3(0.3f, 0f, 0f);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            enemylist.Add(other.gameObject);
        }
        if (other.gameObject.tag == "Warrior")
        {
            warriorlist.Add(other.gameObject);
        }
    }
    IEnumerator FindEnemy()
    {
        findstate = false;
        FindTarget();
        yield return new WaitForSeconds(attackSpeed);
        enemylist[enemyTarget].transform.position = startPos;
        yield return new WaitForSeconds(gameSpeed);
        findstate = true;
    }
}
