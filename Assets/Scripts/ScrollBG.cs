using System;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
   [SerializeField] private float _speed = 4f;

   private Vector3 _startPosition;

   [SerializeField] private float _restartAnchor;

   private void Start()
   {
      _startPosition = this.transform.position;
   }

   private void FixedUpdate()
   {
      transform.Translate(Vector3.down * _speed);
   }

   private void Update()
   {
      if (transform.position.y < _restartAnchor)
      {
         transform.position = _startPosition;
      }
   }
}
