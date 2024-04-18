using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour
{
    private float _speed;
    private int _maxSpeed = 15;
    private int _direction = 5;
    private Vector3 _targetPoint;

    private void Start()
    {
        _speed = GetRandomValue(_maxSpeed);
        _targetPoint = new Vector3(0, 0, _direction);
    }

    private void Update()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, _targetPoint, Time.deltaTime * _speed);
    }

    private int GetRandomValue(int maxRandomValue, int minRandomValue = 0)
    {
        int randomValue = Random.Range(minRandomValue, maxRandomValue);
        return randomValue;
    }
}
