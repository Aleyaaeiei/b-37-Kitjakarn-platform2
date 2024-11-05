using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocordie : Enemy, Ishootable
{
    [SerializeField]private float attackRange;
    public Player player;


    [SerializeField] private GameObject bullet; 
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }

    [SerializeField] private Transform spawnPoint;
    public Transform SpawnPoint { get { return spawnPoint; } set { spawnPoint = value; } }

    //colldown bullet
    [SerializeField] private float bulletSpawnTime;
    public float BulletSpawnTime { get { return bulletSpawnTime; } set { bulletSpawnTime = value; } }

    [SerializeField] private float bulletTime;
    public float BulletTime { get { return bulletTime; } set { bulletTime = value; } }


    private void Update()
    {
        BulletTime += Time.deltaTime;
        Behaviour();

        if (BulletTime < 0)
        {
            BulletTime = BulletSpawnTime;
        }
    }

    public override void Behaviour()
    {
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        
        if (distance < attackRange) 
        {
            Shoot();
        
        }

    }
    public void Shoot()
    {
        if (BulletTime >= BulletSpawnTime)
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            Rock rock = obj.GetComponent<Rock>();
            rock.Init(20, this);

            BulletTime = 0;
        }
    
    }
}
