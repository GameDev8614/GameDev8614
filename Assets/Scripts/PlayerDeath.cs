
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private UnityEvent _playerDead;

    public UnityEvent PlayerDead => _playerDead;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Enemy>())
        {
            _playerDead.Invoke();
        }
    }
}
