using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{

    private float speed;
    //public Vector2 MoveDirection = Vector2.right;
   
    public override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;   
        Debug.Log("Banana moves with constant speed using Tranfrom");
       
    }
    public override void OnHitWith(Character character)
    {
        if (character is Enemy) 
        {
            character.TakeDamage(this.Damage);
        }
    }


    private void Start() 
    {
        Damage = 30;
        speed = 6.0f * GetShootDirection();
        Move();

    }

    private void FixedUpdate()
    {
        Move();
    }
}
