using System;
using UnityEngine;

public class EnemyBullet : MonoBehaviour, IDestroyable
{
   [SerializeField] private float _speed;

   public void BulletMove()
   {
      transform.Translate(Vector2.down * _speed);
   }
   
   private void Update()
   {
      BulletMove();
      SelfDestroy();
   }

   public void SelfDestroy()
   {
      if (transform.position.y < -5)
      {
         Destroy(gameObject);  
      }
   }
}
