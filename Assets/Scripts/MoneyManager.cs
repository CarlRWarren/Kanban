using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI m_moneyText = null;

    private int m_money = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_money = PlayerPrefs.GetInt("Money");
    }

    // Update is called once per frame
    void Update()
    {
        m_moneyText.text = "$" + m_money.ToString("D5");
        PlayerPrefs.SetInt("Money", m_money);
    }

    public void AddMoney()
    {
        m_money += 1;
    }

    public void LoseMoney(int amount)
    {
        m_money -= amount;
    }
}
