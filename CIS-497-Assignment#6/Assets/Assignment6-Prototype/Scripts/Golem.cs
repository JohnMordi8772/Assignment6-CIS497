/*
 John Mordi
 Assignment #6
 Representation of a child class.
		 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int dmg;

    protected override void Awake()
    {
        base.Awake();
        health = 120;
        dmg = 10;
        GameManager.Instance.score += 2;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Inflicted Damage!");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("Took Damage!");
    }
}
