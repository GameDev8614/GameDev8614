using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private float _horizontalMove;
   public float HorizontalMove => _horizontalMove;
   
   private float _verticalMove;
   public float VerticalMove => _verticalMove;

   private Vector2 _moveDirection;

   [SerializeField] private float _moveSpeed;

   public void Move()
   {
      _horizontalMove = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
      _verticalMove = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
      
      _moveDirection = new Vector2(_horizontalMove, _verticalMove);
      transform.Translate(_moveDirection);
   }

   public void LimitPlayer()
   {
      transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8, 8),
                                       Mathf.Clamp(transform.position.y, -3, 0.5f));
   }
   private void Update()
   {
      Move();
      LimitPlayer();
   }
}
