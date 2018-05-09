using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMClass : GenericClass {

    public GameObject projectile, projectileSpawn; // Spawns heart projectiles
    public GameObject proj; // Spawns lasers

    public HeartMClass() {
        attacks = new string[2];
        attacks[0] = "Heart Pulse";
        attacks[1] = "Headshot";
    }

    public override void AttackOne() {
        if (ener >= 2) {
            isAttacking = true;
            anim.Play("ATTACK", -1, 0f);
            GameObject tempProj = Instantiate(projectile, projectileSpawn.transform);
            Destroy(tempProj, 3.0f);
            ReduceEnergy(2);
            isAttacking = false;
        }
    }

    public override void AttackTwo() {
        if (ener >= 4) {
            isAttacking = true;
            anim.Play("ATTACK", -1, 0f);
            GameObject tempProj = Instantiate(proj, projectileSpawn.transform);
            Destroy(tempProj, 3.0f);
            ReduceEnergy(4);
            isAttacking = false;
        }
    }
}
