using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallOut : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
	{
		SceneManager.LoadScene("Runner");
	}
}
