using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject rotationGameObj;
    [SerializeField] float speed;

    private void OnEnable()
    {
        rotationGameObj = GameObject.Find("RoatationGameObj");
        speed = rotationGameObj.GetComponent<RotationGameObjManager>().Speed;
        transform.localRotation = rotationGameObj.transform.localRotation;
    }

    private void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
