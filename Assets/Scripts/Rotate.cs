using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * Speed);
    }
}
