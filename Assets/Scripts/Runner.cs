using UnityEngine;

public enum RoadLine
{
    Left = -1,
    Middle,
    Right

}

public class Runner : State
{
    [SerializeField] Animator animator;
    [SerializeField] RoadLine roadLine;
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] float speed = 25.0f;
    [SerializeField] float positionX = 2.5f;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }

    private new void OnEnable()
    {
        base.OnEnable();

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
                animator.Play("left_Avoid");
                roadLine--;
            }
        }
        //오른쪽 이동
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (roadLine != RoadLine.Right)
            {
                animator.Play("right_Avoid");
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
        if (state == false) return;

        OnMovedUpdate();
    }


    private new void OnDisable()
    {
        if (state == false) return;

        base.OnDisable();

        InputManager.Instance.action -= OnKeyUpdate;
    }
}