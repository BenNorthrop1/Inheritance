using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public virtual void HandleAttackPlayer()
    {
        Debug.Log("Enemy Attacks Player");
    }
}
