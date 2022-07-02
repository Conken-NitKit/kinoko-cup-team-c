﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// パズルに関するスクリプト
/// 左クリックしながら動かしたときにそのブロックを判定して消したりすることができる
/// </summary>
public class TouchManager : MonoBehaviour
{
	[SerializeField]
	private GameObject[] blocks;

	private GameObject firstBall;
	private GameObject lastBall;
	private string currentName;
	private int value;
	private float plusAngleValue = 60;
	private float minusAngleValue = -60;
	private float generateX = 0;
	private float generateY = 10;
	private float generateZ = 0;
	List<GameObject> removableBallList = new List<GameObject>();

    void FixedUpdate()
    {
		if (Input.GetMouseButtonDown(0) && firstBall == null)
		{
			OnDragStart();
		}
		else if (Input.GetMouseButtonUp(0))
		{
			OnDragEnd();
		}
		else if (firstBall != null)
		{
			OnDragging();
		}
	}
	private void OnDragStart()
	{
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

		if (hit.collider != null)
		{
			GameObject hitObj = hit.collider.gameObject;
			string ballName = hitObj.name;
			if (ballName.StartsWith("Block"))
			{
				firstBall = hitObj;
				lastBall = hitObj;
				currentName = hitObj.name;
				removableBallList = new List<GameObject>();
				PushToList(hitObj);
			}
		}
	}

	private void OnDragging()
	{
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		if (hit.collider != null)
		{
			GameObject hitObj = hit.collider.gameObject;

			if (hitObj.name == currentName && lastBall != hitObj)
			{
				float distance = Vector2.Distance(hitObj.transform.position, lastBall.transform.position);
				if (distance < 5.0f)
				{
					lastBall = hitObj;
					PushToList(hitObj);
				}
			}
		}
	}

	private void OnDragEnd()
	{
		int remove_cnt = removableBallList.Count;
		if (remove_cnt >= 3)
		{
			for (int i = 0; i < remove_cnt; i++)
			{
				Destroy(removableBallList[i]);
			}
			StartCoroutine(DropBall(remove_cnt));
		}
		firstBall = null;
		lastBall = null;
	}

	void PushToList(GameObject obj)
	{
		removableBallList.Add(obj);
	}

	IEnumerator DropBall(int blockCount)
	{
		blockCount--;
		if (blockCount == 0)
		{
			yield break;
		}
		value = Random.Range(0, blocks.Length);
		Instantiate(blocks[value], new Vector3(generateX, generateY, generateZ), Quaternion.Euler(0, 0, Random.Range(plusAngleValue, minusAngleValue)));
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(DropBall(blockCount));
	}
}


