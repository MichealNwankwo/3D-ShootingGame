using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour
{

    [SerializeField]
    private GameObject collisionSound;   

    [SerializeField]
    private GameObject collisionParticle;



    private GameObject collisionObject;
   private GameObject collisionParticleObj;

    // private void Start()
    // {
    //     collisionSound = GetComponent<AudioSource>();
    // }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("asteroids"))
        {
             Destroy(other.gameObject);
            collisionObject =  Instantiate(collisionSound);

            collisionParticleObj =  Instantiate(collisionParticle, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(collisionParticleObj, 2);

             KeepScore.Score += 100;
             Debug.Log("Score = " + KeepScore.Score);
        }
       
      


        Destroy (gameObject);
        Destroy (collisionObject, 2);
    }
}
