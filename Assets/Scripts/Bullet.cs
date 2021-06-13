using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _flySpeed;
    [SerializeField] private float _destroyPoint;
   
    void FixedUpdate()
    {
        BulletFly();
        DestroyBullet();
    }

    public void BulletFly()
    {
        transform.Translate(Vector2.up * _flySpeed);
    }

    public void DestroyBullet()
    {
        if (transform.position.y > _destroyPoint)
        {
            Destroy(gameObject);
        }
    }
}
