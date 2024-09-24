using UnityEngine;

public class RotationGameObjManager : MonoBehaviour
{
    [SerializeField] float speed = 50f;

    public float Speed
    {
        get { return speed; }

    }
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
