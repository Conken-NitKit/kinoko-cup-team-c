using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ブロックを制御するスクリプト
/// </summary>
public class BlockController : MonoBehaviour
{

    void FixedUpdate()
    {
        
    }

    /// <summary>
    /// BlockDestroyerに当たると消えるスクリプト
    /// </summary>
    /// <param name="otherObj"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.StartsWith("Block"))
        {
            Destroy(gameObject);
        }
    }
}
