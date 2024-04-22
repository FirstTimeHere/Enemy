using System.Collections;
using TMPro;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Enemy _enemy;


    [SerializeField][Range(0.1f, 10f)] private float _delay;
    [SerializeField][Range(1, 100)] private int _numbersOfEnemy;

    private int _backRotation = -180;

    private void Start()
    {
        StartCoroutine(GetSpawnEnemy(_delay));
    }

    private void Spawn()
    {
        Transform randomSpawn = GetRandomSpawnPoint(_spawnPoints);
        Enemy enemy = Instantiate(_enemy, randomSpawn.position, randomSpawn.rotation);

        Vector3 direction;

        if (randomSpawn.localEulerAngles.y == _backRotation)
        {
            direction = Vector3.back;
        }
        else
        {
            direction = Vector3.forward;
        }

        enemy.GetTransform(direction);
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

    private Transform GetRandomSpawnPoint(Transform[] spawnPoints)
    {
        int randomValue = Random.Range(0, spawnPoints.Length);
        return spawnPoints[randomValue];
    }
}
