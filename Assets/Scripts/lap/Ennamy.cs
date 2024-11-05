using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ennamy :Character
{
    private int damagehit;
    public int DamageHit
    {
        get 
        { 
          return damagehit;
        }
        set 
        { 
           damagehit = value;
        
        }
           
    }

    private void Start()
    {
        Behaviour();
    }

    public abstract void Behaviour();
    
    
    
    
    
}
