using System;
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy, IDestroyable
{
    [HideInInspector] public float Health { get; set; }
    [SerializeField] private GameObject _bullet;
    

    private void Start()
    {
        Health = 5;
        Shoot();
    }

    public void GetDamage(float damageAmount)
    {
        Health -= damageAmount;
    }

    public void Shoot()
    {
        StartCoroutine(ShootBullets());
    }

    private IEnumerator ShootBullets()
    {
        while (true)
        {
            Instantiate(_bullet, transform.position, Quaternion.Euler(0, -180, 0));
            yield return new WaitForSeconds(1);
        }
        
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
