using System;
using UnityEngine;
using UnityEngine.UI;

public class TimerCounter : MonoBehaviour
{
   [SerializeField] private float _timeStart = 60;

   [SerializeField] private Text _timerText;

   [SerializeField] private PlayerDeath _playerDeath;

   private void Start()
   {
      MinusTime();
   }

   private void Update()
   {
      MinusTime();
   }

   public void MinusTime()
   {
      if (_timeStart > 0)
      {
         _timeStart -= Time.deltaTime;
         _timerText.text = $"Time Left: {Mathf.Round(_timeStart).ToString()}";
      }
      else
      {
         _playerDeath.PlayerDead.Invoke();
      }
      
   }
}
