using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bnana : Weapon
{

    //private float speed = 4f;
    //public Vector2 MoveDirection = Vector2.right;
   
    public  override void Move()
    {
        //transform.transform.position = MoveDirection;
        Debug.Log("Banana moves with constant speed using Tranfrom");
       
    }
    public override void OnHitWith(Character _character)
    {
        
    }

    private void Start() 
    {
        Damage = 30;
        Move();

    
    
    
    }
}
