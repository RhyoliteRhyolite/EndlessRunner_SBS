using System.Collections;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{

    [SerializeField] float speed = 20f;
    [SerializeField] float limitSpeed = 100f;
    [SerializeField] float increaseValue = 5f;

    public float Speed
    {
        get { return speed; }
    }

    private void Awake()
    {
        StartCoroutine(Accelerate());
    }

    IEnumerator Accelerate()
    {
        while (speed < limitSpeed)
        {
            yield return CoroutineChache.WaitForSecond(10);

            speed += increaseValue;
        }
    }
}
