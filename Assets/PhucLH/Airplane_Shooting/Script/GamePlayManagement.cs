using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GamePlayManagement : MonoBehaviour
{
    public Enemy enemyPrefab;
    public GameObject bulletPrefab;
    private ShipMovement ship;
    public float spawnBulletTime;
    public float moveTime;
    private int squadStatus = 0;
    private List<Enemy> enemyList = new List<Enemy>();
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy();
        ship = FindObjectOfType<ShipMovement>();
        StartCoroutine(spawnBullet());
        StartCoroutine(squadLoop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnBullet()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnBulletTime);
            var position = ship.transform.position;
            GameObject bullet = Instantiate(bulletPrefab, position, Quaternion.identity);
        }    
    }
    private void spawnEnemy()
    {
        int numberOfEnemy = 16;
        Vector3 spawnPosition = new Vector3(0, 10, 0);
        for(int i=0; i<numberOfEnemy; i++)
        {
            Enemy enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            enemyList.Add(enemy);    
        }    
    }    
    private IEnumerator squadLoop()
    {
        while(true)
        {
            yield return new WaitForSeconds(moveTime);
            if(squadStatus%4==0)
            {
                changeSquadFormation(SquadFormat.SquareFormation());
            }
            else if(squadStatus%4==1)
            {
                changeSquadFormation(SquadFormat.RhombusFormat());
            }
            else if (squadStatus % 4 == 2)
            {
                changeSquadFormation(SquadFormat.TriangleFormat());
            }
            else
            {
                changeSquadFormation(SquadFormat.RectangleFormat());
            }
            squadStatus++;        
        }    
    }
    
    private void changeSquadFormation(Vector3[] vector3s)
    {
        for(int i=0; i<vector3s.Length;i++)
        {
            var enemy = enemyList[i];
            enemy.Moving(vector3s[i]);
        }    
    }

   
}
