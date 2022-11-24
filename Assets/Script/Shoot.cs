using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletObject;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private float bulletForceValue;

    [SerializeField]
    private AudioSource bulletSound;


    private GameObject spawnBullet;
    private Rigidbody spawnBulletBody;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        spawnBullet = Instantiate(bulletObject, spawnPoint.position, spawnPoint.rotation);

        bulletSound.Play();

        spawnBulletBody = spawnBullet.GetComponent<Rigidbody>();
        spawnBulletBody.AddForce(spawnPoint.forward * bulletForceValue);

        Destroy(spawnBullet, 4);
        }
    }
}
