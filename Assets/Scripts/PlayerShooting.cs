using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class PlayerShooting : MonoBehaviour
{
   [SerializeField] private UnityEvent _onPlayerShooted;
   [SerializeField] private GameObject _bullet;
   [SerializeField] private List<GameObject> _placesToSpawn;

   public void ShootOneBullet()
   {
      Instantiate(_bullet, _placesToSpawn[0].transform.position, quaternion.identity);
   }

   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         _onPlayerShooted.Invoke();
      }
   }
}
