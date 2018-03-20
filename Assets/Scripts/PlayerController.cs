using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10.0f;

    private Rigidbody rigid;

    void Start() {
        rigid = GetComponent<Rigidbody>();
    }

    void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v) * speed * Time.deltaTime;

        rigid.MovePosition(transform.position + movement);
	}
}
