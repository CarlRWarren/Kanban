using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float timer = 0.0f;
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponentInChildren<Animator>().SetTrigger("Hop");
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponentInChildren<Animator>().SetTrigger("Hop");
            transform.rotation = new Quaternion(0, -90, 0, 0);
            transform.Translate(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponentInChildren<Animator>().SetTrigger("Hop");
            transform.rotation = new Quaternion(0, 90, 0, 0);
            transform.Translate(Vector3.right);
        }
    }
}
