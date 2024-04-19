using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private int _speed;
    private int _maxSpeed = 15;
    private int _rotation = 1; //180

    private void Start()
    {
        _speed = Random.Range(0, _maxSpeed);
    }

    private void Update()
    {
        if (transform.rotation.y == _rotation)
            transform.position -= new Vector3(0, 0, Time.deltaTime * _speed);
        else
            transform.position += new Vector3(0, 0, Time.deltaTime * _speed);

    }
}
