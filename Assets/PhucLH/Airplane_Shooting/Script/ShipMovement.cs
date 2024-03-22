using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPosition;
    [SerializeField] protected float mouseSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        this.worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.worldPosition.z = 0;
        Vector3 newPosition = Vector3.Lerp(transform.position, worldPosition, this.mouseSpeed);
        transform.position = newPosition;
    }
}
