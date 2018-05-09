using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericClass : MonoBehaviour {

    public int hp, ener, atk, dex, def, luk;
    public float spd;
    public Animator anim;

    protected string[] attacks;
    protected bool isAttacking = false;

    private Rigidbody rigid;


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        if (!isAttacking)
            Movement();
    }

    public void TakeDamage(int amt)
    {
        Debug.Log("I took damage");
        anim.Play("DAMAGED", -1, 0f);
        if ((hp - (amt - def)) > 0)
         hp -= (amt - def);
        else {
            hp = 0;
            Death();
        }
    }

    public void ReduceEnergy(int amt) {
        ener -= amt;
    }

    public void Movement()
    {
        if (gameObject.CompareTag("Player") && !isAttacking)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(h, 0, v) * spd * Time.deltaTime;

            anim.SetFloat("inputH", h);
            anim.SetFloat("inputV", v);

            rigid.MovePosition(transform.position + movement);
        }
    }

    public string[] GetAttacks() {
        return attacks;
    }

    public string GetSpecificAttack(int i) {
        return attacks[i];
    }

    public void Swap() {
        anim.SetFloat("inputH", 0.0f);
        anim.SetFloat("inputV", 0.0f);
    }

    public virtual void Death() {
        anim.Play("DEATH", -1, 0f);
        Destroy(gameObject, 0.5f);
    }

    public int GetHP() {
        return hp;
    }

    public void SetHP(int hp) {
        this.hp = hp;
    }

    public int GetEner() {
        return ener;
    }

    public void SetEner(int ener) {
        this.ener = ener;
    }

    public int GetAtk() {
        return atk;
    }

    public void SetAtk(int atk) {
        this.atk = atk;
    }

    public int GetDex() {
        return dex;
    }

    public void SetDex(int dex) {
        this.dex = dex;
    }

    public int GetDef() {
        return def;
    }

    public void SetDef(int def) {
        this.def = def;
    }

    public int GetLuk() {
        return luk;
    }

    public void SetLuk(int luk) {
        this.luk = luk;
    }

    public abstract void AttackOne();

    public abstract void AttackTwo();


    
}
