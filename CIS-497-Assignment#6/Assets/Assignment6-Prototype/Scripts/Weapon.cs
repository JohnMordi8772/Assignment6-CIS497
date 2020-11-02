/*
 John Mordi
 Assignment #6
 Examples of polymorphism and composition.
		 */
using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public int damageBonus;
    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon");
    }

    public void Recharge()
    {
        Debug.Log("Weapon recharging!");
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
