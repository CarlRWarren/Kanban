using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject[] m_menuPlayers = null;
    public string m_characterName = "Penguin";
    void Start()
    {
        LoadMainMenu();
    }

    void Update()
    {
        LoadMainMenu();
    }

    public void LoadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jon");
    }

    public void OpenSettings()
    {

    }

    public void OpenShop()
    {

    }

    public void LoadMainMenu()
    {
        switch(m_characterName)
        {
            case "Penguin":
                for(int i = 0; i < m_menuPlayers.Length; i++)
                {
                    m_menuPlayers[i].SetActive(false);
                    if(i == 0) m_menuPlayers[i].SetActive(true);
                }
                break;
            case "Cat":
                for (int i = 0; i < m_menuPlayers.Length; i++)
                {
                    m_menuPlayers[i].SetActive(false);
                    if (i == 1) m_menuPlayers[i].SetActive(true);
                }
                break;
            case "Chicken":
                for (int i = 0; i < m_menuPlayers.Length; i++)
                {
                    m_menuPlayers[i].SetActive(false);
                    if (i == 2) m_menuPlayers[i].SetActive(true);
                }
                break;
            case "Dog":
                for (int i = 0; i < m_menuPlayers.Length; i++)
                {
                    m_menuPlayers[i].SetActive(false);
                    if (i == 3) m_menuPlayers[i].SetActive(true);
                }
                break;
            case "Lion":
                for (int i = 0; i < m_menuPlayers.Length; i++)
                {
                    m_menuPlayers[i].SetActive(false);
                    if (i == 4) m_menuPlayers[i].SetActive(true);
                }
                break;
        }
    }
}
