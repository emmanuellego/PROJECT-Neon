using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeleeEnemyClass : GenericClass {

    public MeleeEnemyClass() {

    }

    public override void Death() {
        Invoke("DelayedMethod", 1.0f);
        anim.Play("DEATH", -1, 0f);
    }

    void DelayedMethod() {
        Debug.Log("Awesome!");
        SceneManager.LoadScene("Scenes/Credits");
        Destroy(gameObject, 0.5f);
    }

    public override void AttackOne() {

    }

    public override void AttackTwo() {

    }
}
