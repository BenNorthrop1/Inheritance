using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : EnemyBase
{
    public override void HandleAttackPlayer()
    {
        Debug.Log("Orc Attacks Player");
    }

    private void Update() 
    {
        HandleAttackPlayer();
    }    
}
