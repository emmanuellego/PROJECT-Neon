using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcarusClass : GenericClass {

    public IcarusClass()
    {
        atk = 10;
        def = 5;
        spd = 12.0f;
    }

    private void Update()
    {
        Movement();
        MeleeAttack();
        if (Input.GetKeyDown(KeyCode.Z))
        {
            print("I pressed Z!");
            MeleeAttack();
        }
    }

    private void MeleeAttack()
    {
        GameObject enemyObj = GameObject.FindGameObjectWithTag("Enemy");
        GenericClass enemy = enemyObj.GetComponent<GenericClass>();
        float dist, maxDist = 2.0f;

        dist = Vector3.Distance(transform.position, enemyObj.transform.position);
        if (dist < maxDist)
        {
            print("Enemy in my sight!");
            anim.Play("MELEE01", -1, 0f);
            enemy.TakeDamage(atk);
        }
    }
}
