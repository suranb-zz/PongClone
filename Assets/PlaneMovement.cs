using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    Vector3 pointA = new Vector3(6, -95, -333);
    Vector3 pointB = new Vector3(6, -95, 45);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 200));
    }
}