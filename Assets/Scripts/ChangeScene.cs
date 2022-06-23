using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// TitleからMainへのシーン移行のスクリプト
/// </summary>
public class ChangeScene : MonoBehaviour
{

    public void ButtonClicked()
    {
            SceneManager.LoadScene("Main");
    }
}
