﻿using System.Collections;
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
    private float plusAngleValue = 60;
    private float minusAngleValue = -60;
    private float generateX = 0;
    private float generateY = 10;
    private float generateZ = 0;

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
        Instantiate(blocks[value], new Vector3(generateX, generateY, generateZ), Quaternion.Euler(0, 0, Random.Range(minusAngleValue, plusAngleValue)));
        yield return new WaitForSeconds(0.1f);
        StartCoroutine("BlockGenerate");
    }
}
