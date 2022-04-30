using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFlow : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;
    public Transform triangle1mObj;
    private Vector3 nextTriangle1mSpawn;
    public Transform triangle3mObj;
    private Vector3 nextTriangle3mSpawn;
    public Transform cube1mObj;
    private Vector3 nextCube1mSpawn;
    public Transform bucket2mObj;
    private Vector3 nextBucket2mSpawn;
    public Transform Blockus2mObj;
    private Vector3 nextBlockus2mSpawn;
    private int randX;
    private int rand;

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
        yield return new WaitForSeconds(0.25f);
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        rand = Random.Range(-1,1);
        randX = Random.Range(-1,2);
        nextTriangle1mSpawn = nextTileSpawn;
        nextTriangle1mSpawn.x = randX + 999*rand;
        nextTriangle1mSpawn.y = .25f;
        Instantiate(triangle1mObj, nextTriangle1mSpawn, triangle1mObj.rotation);
        nextTileSpawn.z += 3;

        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        rand = Random.Range(-1,1);
        randX = Random.Range(-1,2);
        nextCube1mSpawn = nextTileSpawn;
        nextCube1mSpawn.x = randX + 999*rand;
        nextCube1mSpawn.y = .75f;
        Instantiate(cube1mObj, nextCube1mSpawn, cube1mObj.rotation);
        nextTileSpawn.z += 3;

        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        rand = Random.Range(-1,2);
        nextBucket2mSpawn = nextTileSpawn;
        nextBucket2mSpawn.x = 6f; 
        nextBucket2mSpawn.y = 3f + 999*rand;
        Instantiate(bucket2mObj, nextBucket2mSpawn, bucket2mObj.rotation);
        rand = Random.Range(-1,1);
        randX = Random.Range(-1,2);
        nextCube1mSpawn = nextTileSpawn;
        nextCube1mSpawn.x = randX + 999*rand;
        nextCube1mSpawn.y = .75f;
        Instantiate(cube1mObj, nextCube1mSpawn, cube1mObj.rotation);
        rand = Random.Range(-1,1);
        randX = Random.Range(-1,2);
        nextTriangle1mSpawn = nextTileSpawn;
        nextTriangle1mSpawn.x = randX + 999*rand;
        nextTriangle1mSpawn.y = .25f;
        Instantiate(triangle1mObj, nextTriangle1mSpawn, triangle1mObj.rotation);
        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());
    }
}
