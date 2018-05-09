using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeleeEnemyClass : GenericClass {

    public MeleeEnemyClass() {

    }

    public override void Death() {
        anim.Play("DEATH", -1, 0f);
        Destroy(gameObject, 0.5f);
        SceneManager.LoadScene("Scenes/Credits");
    }

    public override void AttackOne() {

    }

    public override void AttackTwo() {

    }
}
