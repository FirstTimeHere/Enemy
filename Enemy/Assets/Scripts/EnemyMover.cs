using UnityEngine;

[RequireComponent (typeof(Target))]

public class EnemyMover : MonoBehaviour
{
    public int Speed {  get; private set; }
    private int _maxSpeed = 15;

    private Target _target;

    private void Awake()
    {
        _target = GetComponent<Target>();
        Speed = Random.Range(0, _maxSpeed);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, Time.deltaTime * Speed);
    }
}
