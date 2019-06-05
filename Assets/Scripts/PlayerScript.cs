using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    float timer = 0.0f;
    public bool inControl = true;

    void Update()
    {
        timer += Time.deltaTime;
        if (inControl)
        {
            if (Input.GetKeyDown(KeyCode.W) && timer >= 0.5f)
            {
                gameObject.GetComponentInChildren<Animator>().SetTrigger("Hop");
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(0, 0, 1)), 180);
                transform.Translate(new Vector3(0, 0, 1));
                timer = 0;
                GameObject.FindGameObjectWithTag("MoneyManager").GetComponent<MoneyManager>().AddMoney();
            }
            if (Input.GetKeyDown(KeyCode.A) && timer >= 0.5f)
            {
                gameObject.GetComponentInChildren<Animator>().SetTrigger("Hop");
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(0, 0, 1)), 180);
                transform.Translate(new Vector3(-1, 0, 0));
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(-1, 0, 0)), 180);
                timer = 0;
            }
            if (Input.GetKeyDown(KeyCode.D) && timer >= 0.5f)
            {
                gameObject.GetComponentInChildren<Animator>().SetTrigger("Hop");
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(0, 0, 1)), 180);
                transform.Translate(new Vector3(1, 0, 0));
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(1,0,0)), 180);
                timer = 0;
            }
        }
    }

    public void Die()
    {
        inControl = false;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(0, -1, 0)), 180);
        transform.Translate(0, -0.8f, 0);
        //Do gameover stuffs
    }
}
