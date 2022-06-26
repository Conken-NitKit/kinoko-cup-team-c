using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ブロックをランダムに生成するスクリプト
/// </summary>
public class BlockGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject[] blocks;

    private int count = 0;
    private const int maxCount = 60;
    private int value;

    [SerializeField]
    private int blockCount;

    void Start()
    {
        StartCoroutine("BlockGenerate");
    }

    void FixedUpdate()
    {

    }

    IEnumerator BlockGenerate()
    {
        blockCount--;
        if (blockCount == 0)
        {
            yield break;
        }
        value = Random.Range(0, blocks.Length);
        Instantiate(blocks[value], new Vector3(0.0f, 10.0f, 0.0f), Quaternion.Euler(0, 0, Random.Range(-60.0f, 60.0f)));
        yield return new WaitForSeconds(0.1f);
        StartCoroutine("BlockGenerate");
    }
}
