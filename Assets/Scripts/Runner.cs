using UnityEngine;

public enum RoadLine
{
    Left = -1,
    Middle,
    Right

}

public class Runner : MonoBehaviour
{
    [SerializeField] RoadLine roadLine;
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] float speed = 25.0f;
    [SerializeField] float positionX = 2.5f;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        InputManager.Instance.action += OnKeyUpdate;
    }

    void Start()
    {
        roadLine = RoadLine.Middle;
    }

    void OnKeyUpdate()
    {
        //왼쪽 이동
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (roadLine != RoadLine.Left)
            {
                roadLine--;
            }
        }
        //오른쪽 이동
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (roadLine != RoadLine.Right)
            {
                roadLine++;
            }
        }
    }

    private void OnMovedUpdate()
    {
        rigidBody.position = Vector3.Lerp
             (
                   rigidBody.position,
                   new Vector3((int)roadLine * positionX, 0, 0),
                   speed * Time.fixedDeltaTime
             );
    }

    private void FixedUpdate()
    {
        OnMovedUpdate();
    }


    private void OnDisable()
    {
        InputManager.Instance.action -= OnKeyUpdate;
    }
}