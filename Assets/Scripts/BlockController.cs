using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �u���b�N�𐧌䂷��X�N���v�g
/// </summary>
public class BlockController : MonoBehaviour
{

    void FixedUpdate()
    {
        
    }

    /// <summary>
    /// BlockDestroyer�ɓ�����Ə�����X�N���v�g
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
