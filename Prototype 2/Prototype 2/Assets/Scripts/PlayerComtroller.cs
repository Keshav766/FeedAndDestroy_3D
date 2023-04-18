using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComtroller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float boundryRange = 10.0f;
    public float foodSpawnHeight = 2f;

    public GameObject projectileMeat;
    public GameObject projectileCarrot;
    public GameObject projectileApple;
    public GameObject projectileBone;

    public Camera thirdPerson;
    public Camera firstPerson;
    public KeyCode swithKey;

    void Start()
    {

    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        if (transform.position.x < -boundryRange)
        {
            transform.position = new Vector3(-boundryRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > boundryRange)
        {
            transform.position = new Vector3(boundryRange, transform.position.y, transform.position.z);
        }


        // Food Projectiles coding
        if(Input.GetKeyDown(KeyCode.Keypad0))
        {
            Instantiate(projectileMeat, transform.position + new Vector3(0, foodSpawnHeight ,0), transform.rotation);
        }
        else if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            Instantiate(projectileBone, transform.position + new Vector3(0, foodSpawnHeight ,0), transform.rotation);
        }
        else if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            Instantiate(projectileCarrot, transform.position + new Vector3(0, foodSpawnHeight ,0), transform.rotation);
        }
        else if(Input.GetKeyDown(KeyCode.Keypad3))
        {
            Instantiate(projectileApple, transform.position + new Vector3(0, foodSpawnHeight ,0), transform.rotation);
        }

         if(Input.GetKeyDown(swithKey))
        {
            firstPerson.enabled = !firstPerson.enabled;
            thirdPerson.enabled = !thirdPerson.enabled;
        }
    }
}
