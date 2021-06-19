using System;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy, IDestroyable
{
    [HideInInspector] public float Health { get; set; }
    

    private void Start()
    {
        Health = 5;
    }

    public void GetDamage(float damageAmount)
    {
        Health -= damageAmount;
    }

    public void Shoot()
    {
   
    }

    public void SelfDestroy()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        SelfDestroy();
    }
}
