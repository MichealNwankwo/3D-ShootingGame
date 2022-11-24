using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public Vector3 rotateValue;

  [SerializeField]
  float spinSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateValue * Time.deltaTime * spinSpeed); 
    }
}
