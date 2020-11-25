using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;
public class CreateUnits : MonoBehaviour
{
    public GameObject[]
        Warriors,
        Enemies,
        EnemySpawnPoint,
        WarriorSpawnPoint;
    private GameObject
        enemy,
        warrior;
    Quaternion enemrot = new Quaternion(0f, 180f, 0f, 0f); //x,y,z,w(w formal variable)
    Vector2 EnemSpawnPoint,
        WarSpawnPoint;


    void Start()
    {
        CreUnits();
    }

    void CreUnits()
    {
        CreateWarriors();
        CreateEnemies();
    }
    void CreateEnemies()
    {
        for (int i = 0; i < 3; i++) //i-количество повторений
        {
            enemy = Enemies[Random.Range(0, Enemies.Length)];
            EnemSpawnPoint = EnemySpawnPoint[i].transform.position;
            Instantiate(enemy, EnemSpawnPoint, enemrot);
        }
    }
    void CreateWarriors()
    {
        for (int i = 0; i < 3; i++)//i-количество повторений
        {
            warrior = Warriors[Random.Range(0, Warriors.Length)];
            WarSpawnPoint = WarriorSpawnPoint[i].transform.position;
            Instantiate(warrior, WarSpawnPoint, Quaternion.identity);
        }
    }
}
