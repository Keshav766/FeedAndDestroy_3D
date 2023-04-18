using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private int score;
    public AudioClip eww;
    public AudioClip yummy;

    AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Forest")
        {
            if (other.gameObject.tag == "Carrot")
            {

                SuccessfullCollision(other);
            }
            else
            {
                FailedCollision(other);
            }
        }
        if (gameObject.tag == "Farm")
        {
            if (other.gameObject.tag == "Apple")
            {

                SuccessfullCollision(other);
            }
            else
            {
                FailedCollision(other);
            }
        }
        if (gameObject.tag == "Dog")
        {
            if (other.gameObject.tag == "Bone")
            {

                SuccessfullCollision(other);
            }
            else
            {
                FailedCollision(other);
            }
        }
        if (gameObject.tag == "Human")
        {
            if (other.gameObject.tag == "Meat")
            {

                SuccessfullCollision(other);
            }
            else
            {
                FailedCollision(other);
            }
        }
    }

    void SuccessfullCollision(Collider other)
    {
        // audioSource.PlayOneShot(yummy, 1);
        Destroy(gameObject);
        Destroy(other.gameObject);
        
    }
    void FailedCollision(Collider other)
    {
        audioSource.PlayOneShot(eww, 1);
        Destroy(other.gameObject);
       
    }
}
