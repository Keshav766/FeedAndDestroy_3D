using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    public float foodSpeed = 30.0f;
    public float rotateSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward * foodSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * foodSpeed * Time.deltaTime,Space.World);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime,Space.World );
    }
}
