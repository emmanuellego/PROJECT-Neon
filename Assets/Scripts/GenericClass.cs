using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass : MonoBehaviour {

    public int hp, ener, atk, dex, def, luk;
    public float spd;
    public Animator anim;

    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    public void TakeDamage(int amt)
    {
        anim.Play("DAMAGED", -1, 0f);
        if ((hp - (amt - def)) > 0)
         hp -= (amt - def);
        else {
            hp = 0;
            Destroy(gameObject);
        }
    }

    public void Movement()
    {
        if (gameObject.CompareTag("Player"))
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(h, 0, v) * spd * Time.deltaTime;

            anim.SetFloat("inputH", h);
            anim.SetFloat("inputV", v);

            rigid.MovePosition(transform.position + movement);
        }
    }
}
