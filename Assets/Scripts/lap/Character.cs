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

    //method

    public bool IsDead()
    {
        return health <= 0;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    public void InIt(int newHealth)
    { 
        Health = newHealth;
    
    }

}
