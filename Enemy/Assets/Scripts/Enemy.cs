using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 Direction {  get; private set; }

    public void GetTransform(Vector3 transformDirection)
    {
        Direction = transformDirection;
    }
}
