using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrink : MonoBehaviour
{
    public Transform playerTransform;
    public float shrinkFactor = 2f; //doesn't make a bit of difference
    public float waitTime = 0.001f; //???
    public float minSize = 0.1f;
    
    private void Start() {
        playerTransform = GameObject.FindWithTag("Player").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("shrinking");
        StartCoroutine(Shrink());
    }
    IEnumerator Shrink() {
        float timer =0f;
        
        while (playerTransform.localScale.x >= minSize){
            timer += Time.deltaTime;
            playerTransform.localScale -= new Vector3(0.5f, 0.5f, 0.5f) * timer * shrinkFactor;
            // playerTransform.localScale /= shrinkFactor; // why the fuck does this work (when just placing cube in front of me to roll through, i set shrinkfactor to 1 and it worked still)
            // playerTransform.localScale /= 1;            // but this doesn't work
            // yield return new WaitForSeconds(waitTime); // can't make it work well enough
            yield return null;
        }
    }
}
