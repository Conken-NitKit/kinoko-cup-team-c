using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 魔法使いに関する全処理を管理するクラス
/// </summary>
public class WizardManager : MonoBehaviour
{
    [SerializeField] TouchManager touchManager;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Debug.Log(touchManager.wizardCount);
    }
}
