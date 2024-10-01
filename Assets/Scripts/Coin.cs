using UnityEngine;

public class Coin : State
{
    [SerializeField] GameObject rotationGameObj;
    [SerializeField] float speed;

    private new void OnEnable()
    {
        base.OnEnable();

        rotationGameObj = GameObject.Find("RoatationGameObj");
        speed = rotationGameObj.GetComponent<RotationGameObjManager>().Speed;
        transform.localRotation = rotationGameObj.transform.localRotation;
    }

    private void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
