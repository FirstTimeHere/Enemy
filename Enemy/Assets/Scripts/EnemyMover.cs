using UnityEngine;

[RequireComponent(typeof(Enemy))]

public class EnemyMover : MonoBehaviour
{
    private int _speed;
    private int _maxSpeed = 5;

    private Enemy _enemy;

    private void Awake()
    {
        _enemy = GetComponent<Enemy>();
        _speed = Random.Range(0, _maxSpeed);
    }

    private void Update()
    {
        transform.Translate(_enemy.Direction * Time.deltaTime * _speed);
    }
}
