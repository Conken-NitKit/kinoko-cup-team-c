using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Title����Main�ւ̃V�[���ڍs�̃X�N���v�g
/// </summary>
public class ChangeScene : MonoBehaviour
{

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
