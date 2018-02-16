using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneChange : MonoBehaviour
{
    string sceneName;
    public void OnPress_Button()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            sceneName = EventSystem.current.currentSelectedGameObject.name;
            if (sceneName == "Exit")
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            }

        }

    }
}
