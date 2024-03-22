using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health=5;
    private bool canBeDamaged;
    public float changeSquadTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(health==0)
        {
            gameObject.SetActive(false);
            GamePlayManagement.Instance.Score++;
        }      
    }

    IEnumerator MoveCoroutine(Vector3 target)
    {
        canBeDamaged = false;
        float elapsedTime = 0;

        Vector3 startingPosition = transform.position;

        while (elapsedTime < changeSquadTime)
        {
            transform.position = Vector3.Lerp(startingPosition, target, (elapsedTime / changeSquadTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = target;
        canBeDamaged = true;
    }


    public void Moving(Vector3 position)
    {
        StartCoroutine(MoveCoroutine(position));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet")&&canBeDamaged)
        {
            health--;
        }    
            
    }


}
