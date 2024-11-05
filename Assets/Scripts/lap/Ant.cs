using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Ant : Ennamy
{
    [SerializeField]private Vector2 velocity;
    [SerializeField]private Transform[] moveOpints;

    private void Start()
    {
        Init(10);
        Behaviour();
    }



    public void Init(int newHealth)
    {
        Health = newHealth;
    
    
    }
    private void FixedUpdate()
    {
        Behaviour();
    }


    
    public override void Behaviour()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (rb.position.x <= moveOpints[0].position.x && velocity.x<0)
        {
            FlipCharacter();
        
        }
        if (rb.position.x >= moveOpints[1].position.x && velocity.x > 0)
        {
            FlipCharacter();

        }


    }
    private void FlipCharacter()
    {
        velocity *= -1;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;


    }

}

