using UnityEngine;
using static IInteractable;

public class Coin : State, IHitable
{
    [SerializeField] GameObject rotationGameObj;
    [SerializeField] float speed;

    public void Activate()
    {
        gameObject.SetActive(false);
    }
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
