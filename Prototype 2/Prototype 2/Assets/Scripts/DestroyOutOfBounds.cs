using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topLimit = 140.0f;
    private float bottomLimit = -15.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topLimit)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
