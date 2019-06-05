using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Owned : MonoBehaviour
{
    public bool owned = false;
    public List<GameObject> buttons = new List<GameObject>(); 
    void Start()
    {
        buttons[0].GetComponent<Button>().GetComponentInChildren<Text>().text = "Select";
        buttons[1].GetComponent<Button>().GetComponentInChildren<Text>().text = "Buy";
        buttons[0].SetActive(false);
        buttons[1].SetActive(true);
        if (gameObject.name == "PenguinPedestal")
        {
            buttons[0].SetActive(true);
            buttons[1].SetActive(false);
        }
    }

    void Update()
    {

    }
    public void BoughtToSelect(bool enoughMoney=true)
    {
        if (enoughMoney)
        {
            buttons[0].SetActive(true);
            buttons[1].SetActive(false);
        }
    }
}
