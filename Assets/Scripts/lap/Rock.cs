using System.Collections;

using System.Collections.Generic;

using Unity.VisualScripting;

using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb2d;

    private Vector2 force;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        Damage = 20;

        force = new Vector2(GetShootDirection() * 2, 10);

        Move();
    }

    public override void Move()

    {
        rb2d.AddForce(force, ForceMode2D.Impulse);
    }
    public override void OnHitWith(Character character)

    {

        if (character is Player)

        {
            character.TakeDamage(this.Damage);
        }

    }

}

