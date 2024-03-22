using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadFormat : MonoBehaviour
{
    public static Vector3[] SquareFormation()
    {
        Vector3[] positions = new Vector3[16];

        positions[0] = new Vector3(-1.5f, 3f, 0f);
        positions[1] = new Vector3(-0.5f, 3f, 0f);
        positions[2] = new Vector3(0.5f, 3f, 0f);
        positions[3] = new Vector3(1.5f, 3f, 0f);

        positions[4] = new Vector3(-1.5f, 4f, 0f);
        positions[5] = new Vector3(-0.5f, 4f, 0f);
        positions[6] = new Vector3(0.5f, 4f, 0f);
        positions[7] = new Vector3(1.5f, 4f, 0f);

        positions[8] = new Vector3(-1.5f, 5f, 0f);
        positions[9] = new Vector3(-0.5f, 5f, 0f);
        positions[10] = new Vector3(0.5f, 5f, 0f);
        positions[11] = new Vector3(1.5f, 5f, 0f);

        positions[12] = new Vector3(-1.5f, 6f, 0f);
        positions[13] = new Vector3(-0.5f, 6f, 0f);
        positions[14] = new Vector3(0.5f, 6f, 0f);
        positions[15] = new Vector3(1.5f, 6f, 0f);

        return positions;
    }    
    public static Vector3[] RhombusFormat()
    {
        Vector3[] positions = new Vector3[16];

        positions[0] = new Vector3(0f, 3f, 0f);

        positions[1] = new Vector3(-1.5f, 4f, 0f);
        positions[2] = new Vector3(-0.5f, 4f, 0f);
        positions[3] = new Vector3(0.5f, 4f, 0f);
        positions[4] = new Vector3(1.5f, 4f, 0f);

        positions[5] = new Vector3(-2.5f, 5f, 0f);
        positions[6] = new Vector3(-1.5f, 5f, 0f);
        positions[7] = new Vector3(-0.5f, 5f, 0f);
        positions[8] = new Vector3(0.5f, 5f, 0f);
        positions[9] = new Vector3(1.5f, 5f, 0f);
        positions[10] = new Vector3(2.5f, 5f, 0f);

        positions[11] = new Vector3(-1.5f, 6f, 0f);
        positions[12] = new Vector3(-0.5f, 6f, 0f);
        positions[13] = new Vector3(0.5f, 6f, 0f);
        positions[14] = new Vector3(1.5f, 6f, 0f);

        positions[15] = new Vector3(0f, 7f, 0f);

        return positions;
    } 
    public static Vector3[] TriangleFormat()
    {
        Vector3[] positions = new Vector3[16];

        positions[0] = new Vector3(0f, 3f, 0f);
        positions[1] = new Vector3(-4f, 3f, 0f);
        positions[2] = new Vector3(-3f, 3f, 0f);
        positions[3] = new Vector3(-2f, 3f, 0f);
        positions[4] = new Vector3(-1f, 3f, 0f);
        positions[5] = new Vector3(1f, 3f, 0f);
        positions[6] = new Vector3(2f, 3f, 0f);
        positions[7] = new Vector3(3f, 3f, 0f);
        positions[8] = new Vector3(4f, 3f, 0f);

        positions[9] = new Vector3(-3f, 4f, 0f);
        positions[10] = new Vector3(3f, 4f, 0f);

        positions[11] = new Vector3(-2f, 5f, 0f);
        positions[12] = new Vector3(2f, 5f, 0f);

        positions[13] = new Vector3(-1f, 6f, 0f);
        positions[14] = new Vector3(1f, 6f, 0f);

        positions[15] = new Vector3(0f, 7f, 0f);

        return positions;
    }
    public static Vector3[] RectangleFormat()
    {
        Vector3[] positions = new Vector3[16];

        positions[0] = new Vector3(0f, 3f, 0f);
        positions[1] = new Vector3(-3f, 3f, 0f);
        positions[2] = new Vector3(-2f, 3f, 0f);
        positions[3] = new Vector3(-1f, 3f, 0f);
        positions[4] = new Vector3(1f, 3f, 0f);
        positions[5] = new Vector3(2f, 3f, 0f);
        positions[6] = new Vector3(3f, 3f, 0f);

        positions[7] = new Vector3(-3f, 4f, 0f);
        positions[8] = new Vector3(3f, 4f, 0f);

        positions[9] = new Vector3(-3f, 5f, 0f);
        positions[10] = new Vector3(-2f, 5f, 0f);
        positions[11] = new Vector3(-1f, 5f, 0f);
        positions[12] = new Vector3(0f, 5f, 0f);
        positions[13] = new Vector3(1f, 5f, 0f);
        positions[14] = new Vector3(2f, 5f, 0f);
        positions[15] = new Vector3(3f, 5f, 0f);

        return positions;
    }
}
