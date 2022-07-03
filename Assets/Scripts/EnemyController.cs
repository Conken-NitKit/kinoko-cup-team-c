using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵の動きに関するスクリプト
/// </summary>
public class EnemyController : MonoBehaviour
{

    [SerializeField]
    private int maxHitPoint;
    [SerializeField]
    private int basicDamage;
    [SerializeField]
    private int enemyAttackCount;

    [SerializeField]
    private GameObject touchManager;

    private int hitPoint;
    private int hitPointPercent;
    private int changePercent = 100;

    public int attackDamage;

    void Start()
    {
        StartCoroutine(EnemyAttack());
    }

    void FixedUpdate()
    {
        
    }

    IEnumerator EnemyAttack()
    {
        hitPointPercent = hitPoint / maxHitPoint * changePercent;
        if(hitPointPercent >= 75)
        {
            attackDamage += basicDamage * enemyAttackCount;
        }
        else if(hitPointPercent >= 50)
        {
            attackDamage += basicDamage * (enemyAttackCount + 1);
        }
        else if(hitPointPercent >= 5)
        {
            attackDamage += basicDamage * (enemyAttackCount + 2);
        }
        else
        {
            attackDamage += basicDamage * (enemyAttackCount + 10);
        }
        touchManager.SetActive(true);
        yield return null;
    }
}
