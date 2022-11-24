using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class KeepScore : MonoBehaviour
{

    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){

        GUI.Box(new Rect(100,100,100,100), Score.ToString ());
    }
}
