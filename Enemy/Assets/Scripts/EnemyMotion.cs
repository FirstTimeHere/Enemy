using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour
{
    private int _speed;
    private int _maxSpeed = 15;
    private int _direction = 5;
    private int _rotation = 1; //180

    private Vector3 _targetPointForward;
    private Vector3 _targetPointBackward;

    private void Start()
    {
        _speed = GetRandomValue(_maxSpeed);
        _targetPointForward = new Vector3(transform.position.x, transform.position.y, transform.position.z + _direction);
        _targetPointBackward = new Vector3(transform.position.x, transform.position.y, transform.position.z - _direction);
    }

    private void Update()
    {
        if (transform.rotation.y == _rotation)
            transform.position = Vector3.MoveTowards(transform.position, _targetPointBackward, Time.deltaTime * _speed);
        else
            transform.position = Vector3.MoveTowards(transform.position, _targetPointForward, Time.deltaTime * _speed);
    }

    private int GetRandomValue(int maxRandomValue, int minRandomValue = 0)
    {
        int randomValue = Random.Range(minRandomValue, maxRandomValue);
        return randomValue;
    }
}
