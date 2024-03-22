using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    private bool canBeDamaged;
    public float changeSquadTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveCoroutine(Vector3 target)
    {
        float elapsedTime = 0;

        Vector3 startingPosition = transform.position;

        while (elapsedTime < changeSquadTime)
        {
            transform.position = Vector3.Lerp(startingPosition, target, (elapsedTime / changeSquadTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = target;
    }


    public void Moving(Vector3 position)
    {
        StartCoroutine(MoveCoroutine(position));
    }


}
