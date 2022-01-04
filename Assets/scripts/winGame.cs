using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class winGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();  
        EditorApplication.isPlaying = false;
    }
}
