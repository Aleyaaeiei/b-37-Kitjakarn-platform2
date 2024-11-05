using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] public string  Ishootable;
    
    private int damage;
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

    public abstract void OnHitWith(Character _character);
    public abstract void Move();
   
    public int GetShootDiraction()
    {
        return 1;
    
    }

}
