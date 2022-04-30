using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// https://forum.unity.com/threads/how-to-make-camera-rotation-match-player-rotation.1015162/
// You need to create an empty, attach this script to it, then parent your camera to that empty. After that just drag your char object to Public Transform player

public class camFollow2 : MonoBehaviour
{
    #region variables
    
    private Vector3 targetChoords;
    public Transform player;
    public float turnSpeed = 2f;
    public Quaternion turnToQuat;
    public Vector3 offset;

    #endregion

    void Start()
    {
        targetChoords = player.transform.position;
    }

    void Update()
    {
        turnToQuat = player.transform.rotation;
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Slerp(transform.rotation, turnToQuat, Time.deltaTime * turnSpeed);        
    }
}
