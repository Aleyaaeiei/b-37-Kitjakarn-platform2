using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set 
        { 
           health = value;
        }
    }

    public Animator anim;
    public Rigidbody2D rb;
    public HelthBar healthBar;


    //method

    public bool IsDead()
    {
        return Health <= 0;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        healthBar.UpdateHealthBar(Health);
    }
    public void InIt(int newHealth)
    { 
        Health = newHealth;
        healthBar.SetMaxHP(Health);
        healthBar.UpdateHealthBar(Health);

    }

}
