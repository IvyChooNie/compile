using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class montageToMainPart : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "storyButton":
                SceneManager.LoadScene("1");
                break;



            case "readButton":
                SceneManager.LoadScene("Menu");
                break;

            case "phonicButton":
                SceneManager.LoadScene("firstScene");
                break;
        }
    }
    }
