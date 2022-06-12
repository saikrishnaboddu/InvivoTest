using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    
    public Vector3 objectPosition;
    public static string nameOfObject;
   
    private void Update()
    {
        transform.position = Camera.main.ViewportToWorldPoint(objectPosition);
    }
    private void OnMouseDown()
    {
        nameOfObject = transform.name;
    }
}
