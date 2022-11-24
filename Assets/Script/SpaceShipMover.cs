using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMover : MonoBehaviour
{
    public float forceValue;
    public float torqueValue;




    private Rigidbody spaceshipBody;

    // Start is called before the first frame update
    void Start()
    {
        spaceshipBody=this.GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveObject();

        moveWithMouse();
        
      
    }
    void moveObject()
    {
 if(Input.GetKey(KeyCode.W))
        {
            spaceshipBody.AddForce(forceValue * transform.forward);
        }


        if(Input.GetKey(KeyCode.S))
        {
            spaceshipBody.AddForce(forceValue * -transform.forward);
        }

         if(Input.GetKey(KeyCode.D))
        {
            spaceshipBody.AddForce(forceValue * transform.right);
        }

         if(Input.GetKey(KeyCode.A))
        {
            spaceshipBody.AddForce(forceValue * -transform.right);
        }


        if(Input.GetKey(KeyCode.Q))
        {
            spaceshipBody.AddForce(forceValue * transform.up);
        }
        
        if(Input.GetKey(KeyCode.E))
        {
            spaceshipBody.AddForce(forceValue * -transform.up);
        }

    }

    void moveWithMouse()
    {
        if(Input.GetMouseButton(1))
        {
             spaceshipBody.AddTorque(Input.GetAxis("Mouse X") * torqueValue * transform.up);
        }
         
    }
    
}
