using UnityEngine;
using UnityEngine.UI;

public class SelectBtn : MonoBehaviour
{
    [SerializeField] Text buttonText;
    [SerializeField] AudioClip enterAudioClip;
    private void Awake()
    {
        buttonText = GetComponentInChildren<Text>();
    }

    public void OnEnter()
    {
        buttonText.fontSize = 25;

        AudioManager.Instance.Listen(enterAudioClip);
    }
    public void OnLeave()
    {
        buttonText.fontSize = 14;
    }
    public void OnSelect()
    {
        buttonText.fontSize = 10;
    }
}
