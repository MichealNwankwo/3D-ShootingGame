using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class ShootPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){

         if(collision.gameObject.CompareTag("bullet")){

        // if(collision.transform.name == "Bullet(Clone)"){

            KeepScore.Score += 100;
        } 
    }
}
