using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private int _speed;
    private int _maxSpeed = 15;
    private int _maxRandomValue = 2;
    private int _randomValue;

    private float _rotation = 180;

    private void Awake()
    {
        _speed = Random.Range(0, _maxSpeed);
        _randomValue = Random.Range(0, _maxRandomValue);

        if (_randomValue == 0)
        {
            transform.localEulerAngles = new Vector3(0, _rotation, 0);
        }
        else
        {
            transform.localEulerAngles = Vector3.zero;
        }
    }

    private void Update()
    {

        if (_randomValue == 0)
            transform.position -= new Vector3(0, 0, Time.deltaTime * _speed);
        else
            transform.position += new Vector3(0, 0, Time.deltaTime * _speed);
    }
}
