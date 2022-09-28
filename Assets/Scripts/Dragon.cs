using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : EnemyBase
{
    public override void HandleAttackPlayer()
    {
        Debug.Log("Dragon Attacks Player");
    }
    
    private void Update() 
    {
        HandleAttackPlayer();
    }
}
