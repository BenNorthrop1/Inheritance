using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : EnemyBase
{
    public override void HandleAttackPlayer()
    {
        Debug.Log("Wizard Attacks Player");
    }

    private void Update() 
    {
        HandleAttackPlayer();
    }
}
