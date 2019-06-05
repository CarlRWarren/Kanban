using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFocus : MonoBehaviour
{
    [SerializeField] List<GameObject> gameObjects = new List<GameObject>();
    int index = 0;
    private void Start()
    {
        for(int i=0; i<gameObjects.Count; i++)
        {
            if (i == 0) gameObjects[i].SetActive(true);
            else gameObjects[i].SetActive(false);
        }
    }

    public void SelectRight()
    {
        gameObjects[index].SetActive(false);
        index = index < 4 ? index += 1 : 0;
    }
    public void SelectLeft()
    {
        gameObjects[index].SetActive(false);
        index = index > 0 ? index -= 1 : 4;
    }
    private void Update()
    {
        //60 degrees apart
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObjects[index].SetActive(false);
            index = index > 0 ? index -= 1 : 4;           
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            gameObjects[index].SetActive(false);
            index = index < 4 ? index += 1 : 0;
        }
        switch (index)
        {
            case 0:
                gameObjects[0].SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Penguin");
                break;
            case 1:
                gameObjects[1].SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Cat");
                break;
            case 2:
                gameObjects[2].SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Chicken");
                break;
            case 3:
                gameObjects[3].SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Dog");
                break;
            case 4:
                gameObjects[4].SetActive(true);
                PlayerPrefs.SetString("CharacterName", "Lion");
                break;
        }
    }
    public void BackToMain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Savannah");
    }
}
