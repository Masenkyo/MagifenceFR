using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    int i = 0;
    Vector3[] array = new Vector3[] { (new Vector3(-0.5f, 1.5f)), (new Vector3(-6.5f, 1.5f)), (new Vector3(-6.5f, -2.5f)), (new Vector3(1.5f, -2.5f)), (new Vector3(1.5f, -0.5f)), (new Vector3(3.5f, -0.5f)), (new Vector3(3.5f, 3.5f)), (new Vector3(7.5f, 3.5f)), (new Vector3(7.5f, -2.5f)), (new Vector3(5.5f, -2.5f)), (new Vector3(5.5f, -5f)) };
    void Update()
    {
        Vector3 Direction = array[i] - transform.position;
        Direction /= Direction.magnitude;
        transform.position += Time.deltaTime * Direction;
        if ((array[i] - transform.position).magnitude < 0.01f)
        {
            i++;
        }
    }
}
