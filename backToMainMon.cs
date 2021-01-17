using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMainMon : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "monHomeButton":
                SceneManager.LoadScene("DemoScene");
                break;

            case "monHomeButton01":
                SceneManager.LoadScene("DemoScene");
                break;

            case "monHomeButton02":
                SceneManager.LoadScene("DemoScene");
                break;
        }
    }
}
