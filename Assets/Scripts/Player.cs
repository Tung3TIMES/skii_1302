using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float forcePower;
    [SerializeField] Rigidbody rb;

    private InputAction moveAction;
    private Vector2 moveValue;

    private int point;
    public int Point {  get { return point; } set { point = value; } }

    [SerializeField] private int hp;
    public int HP { get { return hp; } set { hp = value; } }

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move"); 
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftOrRight();
    }

    private void MoveLeftOrRight()
    {
        moveValue = moveAction.ReadValue<Vector2>();

        Vector3 velocity = rb.linearVelocity;
        velocity.x = moveValue.x * forcePower;
        rb.linearVelocity = velocity;
    }
}


