using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject player = null;
    public GameObject[] rows = null;
    public GameObject row = null;

    private void Awake()
    {
        rows = new GameObject[50];

        for (int i = 0; i < rows.Length; i++)
        {
            rows[i] = Instantiate(row, new Vector3(0, 0, i - 2), Quaternion.identity, null);
            rows[i].GetComponent<RowMaker>().Generate();
        }
    }

    void Update()
    {
        if (player != null)
        {
            for (int i = 0; i < rows.Length; i++)
            {
                if (player.transform.position.z - rows[i].transform.position.z > 5)
                {
                    Destroy(rows[i].gameObject);
                    rows[i] = Instantiate(row, new Vector3(0, 0, rows[rows.Length - 1].transform.position.z + i), Quaternion.identity, null);
                    rows[i].GetComponent<RowMaker>().Generate();
                }
            }
        }
    }
}
