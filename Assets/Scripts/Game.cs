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
        PlayerPrefs.SetString("CharacterName", m_characterName);
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

    public void SetCharacter(string character)
    {
        m_characterName = character;
    }

    public void LoadMainMenu()
    {
        for (int i = 0; i < m_menuPlayers.Length; i++)
        {
            m_menuPlayers[i].SetActive(false);
        }
        switch (m_characterName)
        {
            case "Penguin":
                m_menuPlayers[0].SetActive(true);
                m_characterName = "Penguin";
                break;
            case "Cat":
                m_menuPlayers[1].SetActive(true);
                m_characterName = "Cat";
                break;
            case "Chicken":
                m_menuPlayers[2].SetActive(true);
                m_characterName = "Chicken";
                break;
            case "Dog":
                m_menuPlayers[3].SetActive(true);
                m_characterName = "Dog";
                break;
            case "Lion":
                m_menuPlayers[4].SetActive(true);
                m_characterName = "Lion";
                break;
        }
        PlayerPrefs.SetString("CharacterName", m_characterName);
    }
}
