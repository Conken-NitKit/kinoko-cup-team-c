using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 勇者に関する全処理を管理するクラス
/// </summary>
public class BraveManager : MonoBehaviour
{
    [SerializeField] TouchManager touchManager;
    //TouchManagerにBlockの入力回数が決まっている場合
    //入力回数分が終わったかどうかのbool型変数を取得

    void Start()
    {
        Debug.Log("勇者Count：" + touchManager.blaveCount);
    }

    void FixedUpdate()
    {
        
    }
}
