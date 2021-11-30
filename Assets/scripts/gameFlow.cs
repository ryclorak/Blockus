using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFlow : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;
    public Transform hazObj;
    private Vector3 nextHazardSpawn;
    private int randX;

    void Start()
    {
        nextTileSpawn.z = 30;
        StartCoroutine(spawnTile());
    }

    void Update()
    {

    }
    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        randX = Random.Range(-1, 2);
        nextHazardSpawn = nextTileSpawn;
        nextHazardSpawn.x = randX;
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        Instantiate(hazObj, nextHazardSpawn, hazObj.rotation);
        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());
    }
}
