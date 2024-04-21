using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private int _speed;
    private int _maxSpeed = 15;

    private Vector3 _positionTarget;

    private EnemySpawner _spawner;

    private void Awake()
    {
        _spawner = FindObjectOfType<EnemySpawner>();
        _speed = Random.Range(0, _maxSpeed);
    }

    private void Start()
    {
        _positionTarget = _spawner.GetTarget();
    }

    private void Update()
    {
        _positionTarget.z += Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _positionTarget, Time.deltaTime * _speed);
    }
}
