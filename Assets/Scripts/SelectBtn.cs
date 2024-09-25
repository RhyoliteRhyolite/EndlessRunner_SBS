using UnityEngine;
using UnityEngine.UI;

public class SelectBtn : MonoBehaviour
{
    [SerializeField] Text buttonText;

    private void Awake()
    {
        buttonText = GetComponentInChildren<Text>();
    }

    public void OnEnter()
    {
        buttonText.fontSize = 100;
    }
    public void OnLeave()
    {
        buttonText.fontSize = 75;
    }
    public void OnSelect()
    {
        buttonText.fontSize = 50;
    }
}
