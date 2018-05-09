using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float spd = 5;

    private GameObject enemy;

    private void FixedUpdate() {
        Fire();
    }

    void Fire() {
        transform.Translate(Vector3.forward * Time.deltaTime * spd);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Enemy") {
            Debug.Log("Enemy found!");
            enemy = other.transform.parent.gameObject;
            int dex = gameObject.transform.parent.parent.gameObject.GetComponent<GenericClass>().GetDex();
            enemy.GetComponent<GenericClass>().TakeDamage(2 * dex);
            Destroy(gameObject);
        }
    }
}
