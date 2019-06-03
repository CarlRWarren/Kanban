using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player = null;

    public float offX = 0.0f;
    public float offY = 0.0f;
    public float offZ = 0.0f;

    Vector3 offset;

    private void Start()
    {
        offset = new Vector3(offX, offY, offZ);
    }


    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
