using System;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
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
}
