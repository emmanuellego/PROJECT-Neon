using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcarusClass : GenericClass {

    public GameObject projectileSpawn, projectile;

    private bool isEnemy = false;
    private GameObject enemy;
    private AudioSource aud;

    public IcarusClass()
    {
        attacks = new string[2];
        attacks[0] = "Stab";
        attacks[1] = "Knife Throw";
    }

    private void Awake() {
        aud = GetComponentInChildren<AudioSource>();
    }

    public override void AttackOne() {
        if (ener >= 4) {
            isAttacking = true;
            anim.Play("MELEE02", -1, 0f);
            if (isEnemy)
                enemy.GetComponent<GenericClass>().TakeDamage(2 * atk);
            ReduceEnergy(4);
            isAttacking = false;
        }
    }

    public override void AttackTwo() {
        if (ener >= 6) {
            isAttacking = true;
            anim.Play("MELEE01", -1, 0f);
            aud.Play();
            GameObject tempProj = Instantiate(projectile, projectileSpawn.transform);
            Destroy(tempProj, 2.5f);
            ReduceEnergy(6);
            isAttacking = false;
        } 
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.parent.gameObject.tag == "Enemy") {
            Debug.Log("Enemy found!");
            enemy = other.transform.parent.gameObject;
            isEnemy = true;
        }
    }
}
