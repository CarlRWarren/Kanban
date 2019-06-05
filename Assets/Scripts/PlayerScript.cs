using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] GameObject GameManager = null;
    [SerializeField] GameObject moneyBoi = null;

    float timer = 0.0f;
    public bool inControl = true;

    private void Awake()
    {
        PlayerPrefs.SetString("CharacterName", "Penguin");

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        switch(PlayerPrefs.GetString("CharacterName"))
        {
            case "Penguin":
                transform.GetChild(0).gameObject.SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Penguin");
                break;
            case "Cat":
                transform.GetChild(1).gameObject.SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Cat");
                break;
            case "Chicken":
                transform.GetChild(2).gameObject.SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Chicken");
                break;
            case "Dog":
                transform.GetChild(3).gameObject.SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Dog");
                break;
            case "Lion":
                transform.GetChild(4).gameObject.SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Lion");
                break;
        }
    }

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
                moneyBoi.GetComponent<MoneyManager>().AddMoney();
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
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(1, 0, 0)), 180);
                timer = 0;
            }
            if (timer >= 1.5f)
            {
                gameObject.GetComponentInChildren<Animator>().SetTrigger("Hop");
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(0, 0, 1)), 180);
                transform.Translate(new Vector3(0, 0, 1));
                timer = 0;
                moneyBoi.GetComponent<MoneyManager>().AddMoney();
            }
        }
    }

    public void Die()
    {
        inControl = false;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(new Vector3(0, -1, 0)), 180);
        GameManager.GetComponent<Game>().BackToMain();

        //Do gameover stuffs
    }
}
