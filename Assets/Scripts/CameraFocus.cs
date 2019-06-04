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
                break;
            case 1:
                gameObjects[1].SetActive(true);
                break;
            case 2:
                gameObjects[2].SetActive(true);
                break;
            case 3:
                gameObjects[3].SetActive(true);
                break;
            case 4:
                gameObjects[4].SetActive(true);
                break;
        }
       
    }
}
