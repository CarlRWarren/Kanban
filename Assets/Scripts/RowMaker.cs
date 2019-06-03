using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowMaker : MonoBehaviour
{
    public GameObject[] Barriers = null;

    public GameObject[] possibleTiles = null;

    public GameObject[] middleCubes = null;

    public GameObject LeftCap = null;

    public GameObject RightCap = null;

    public void Generate()
    {
        Debug.Log("GENERATING");
        int possibleTilesLength = possibleTiles.Length;
        for(int i = 0; i < middleCubes.Length; i++)
        {
            Destroy(middleCubes[i].gameObject);
            middleCubes[i] = Instantiate(possibleTiles[Random.Range(0, possibleTilesLength)], middleCubes[i].transform.position, Quaternion.identity, gameObject.transform);
        }
        int MaxNum = Barriers.Length;
        LeftCap = Instantiate(Barriers[Random.Range(0, MaxNum)], LeftCap.transform.position, Quaternion.identity, gameObject.transform);
        RightCap = Instantiate(Barriers[Random.Range(0, MaxNum)], RightCap.transform.position, Quaternion.identity, gameObject.transform);
    }
}
