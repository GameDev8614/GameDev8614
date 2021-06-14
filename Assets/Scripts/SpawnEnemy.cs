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
  [SerializeField] private int _taskDelay;

  private void Start()
  {
   StartCoroutine(InstantiateEnemy());
  }
  
  public IEnumerator InstantiateEnemy()
  {
    while (true)
    {
      _randomNumber = Random.Range(0, _enemies.Count);
      _xPosition = Random.Range(-8, 9);
      Instantiate(_enemies[_randomNumber], new Vector2(_xPosition, _yPosition), Quaternion.identity);
      yield return new WaitForSeconds(_taskDelay);
    }
  }
}
