using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, Ishootable //ตรงนี้เพิ่ม isshootable
{
    //เพิ่มมา
    [field: SerializeField] public GameObject Bullet { get; set; }
    
    
    
    [SerializeField] private Transform spawnPoint;
    public Transform SpawnPoint { get { return spawnPoint; } set { spawnPoint = value; } }



    //colldown bullet
    [SerializeField] private float bulletSpawnTime;
    public float BulletSpawnTime { get { return bulletSpawnTime; } set { bulletSpawnTime = value; } }

    [SerializeField] private float bulletTime;
    public float BulletTime { get { return bulletTime; } set { bulletTime = value; } }
    public void Shoot()
    {
        
        if (Input.GetButtonDown( "Fire1") && BulletTime >=  bulletSpawnTime)
        {
            Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            BulletTime = 0;
            Debug.Log("555555555555");
        }

    }
    //
    public void Start()
    {
        InIt(100);
        bulletSpawnTime = 2.0f;
        bulletTime = 0.0f;
    
    
    
    }
    public void Update()
    {
        Shoot();    
    }
    public void FixedUpdate()
    {
        bulletTime += Time.deltaTime;

    }



}
