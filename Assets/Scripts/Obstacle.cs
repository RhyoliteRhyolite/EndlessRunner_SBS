using UnityEngine;
using static IInteractable;

public class Obstacle : MonoBehaviour, IHitable
{
    public void Activate()
    {
        EventManager.Publish(EventType.STOP);
    }

}
