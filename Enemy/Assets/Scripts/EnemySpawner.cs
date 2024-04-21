using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Enemy _enemy;

    [SerializeField][Range(0.1f, 10f)] private float _delay;
    [SerializeField][Range(1, 100)] private int _numbersOfEnemy;

    private void Start()
    {
        StartCoroutine(GetSpawnEnemy(_delay));
    }

    private void Spawn()
    {
        Transform randomSpawn = GetRandomSpawn(_spawnPoints);
        Instantiate(_enemy);
        _enemy.transform.position = randomSpawn.position;
    }

    private IEnumerator GetSpawnEnemy(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (_numbersOfEnemy > 0)
        {
            Spawn();
            _numbersOfEnemy--;
            yield return wait;
        }
    }

    private Transform GetRandomSpawn(Transform[] _spawnPoints)
    {
        int randomValue = Random.Range(0, _spawnPoints.Length);
        return _spawnPoints[randomValue];
    }
}
