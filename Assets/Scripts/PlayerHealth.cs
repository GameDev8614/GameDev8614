using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _hp;
    public float Hp => _hp;
    
    [SerializeField] private Text _hpText;

    [SerializeField] private UnityEvent _onPlayerDead;

    private void Start()
    {
        UpdateText();
    }

    public void DecreaseHp(float damageAmount)
    {
        if (_hp > 0)
        {
            _hp -= damageAmount;
            UpdateText();
        }
        else
        {
            _onPlayerDead.Invoke();
        }
    }

    public void UpdateText()
    {
        _hpText.text = $"Health: {_hp}";
    }
}
