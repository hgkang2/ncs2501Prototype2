using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    public GameObject projectilePrefab;
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
