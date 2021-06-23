using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemy : MonoBehaviour
{
  [SerializeField] private List<GameObject> _enemies;
  
  private float _xPosition;
  private float _yPosition = 6f;

  private int _randomNumber;
  [SerializeField] private float _taskDelay;
  [SerializeField] private GameObject _panel;

  private void Start()
  {
   StartCoroutine(InstantiateEnemy());
  }
  
  public IEnumerator InstantiateEnemy()
  {
    while (!_panel.activeSelf)
    {
      _randomNumber = Random.Range(0, _enemies.Count);
      _xPosition = Random.Range(-8, 9);
      Instantiate(_enemies[_randomNumber], new Vector2(_xPosition, _yPosition), Quaternion.identity);
      yield return new WaitForSeconds(_taskDelay);
      if (_taskDelay > 0.5f)
      {
        _taskDelay -= 0.2f;
      }
    }
  }
}
