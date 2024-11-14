using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] public string  Ishootable;
    
    [SerializeField] private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;

        }
    }

    protected Ishootable shooter;
    public abstract void OnHitWith(Character _character);
    public abstract void Move();

    public void Init (int _damage, Ishootable _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
    }

    public int GetShootDirection()
    {
        float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;
        if (shootDir > 0 ) 
        return 1;
        else return -1;
    
    }

}
