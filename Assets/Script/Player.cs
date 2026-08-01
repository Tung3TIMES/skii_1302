using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float forcePower;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]



    private InputAction moveAction;
    private Vector2 moveValue;

    [SerializeField]
    private int hp;

    public int HP { get { return hp; } set { hp = value; } }

    // Update is called once per frame
    void Update()
    {
        moveAction = new InputAction.actioms.FindAction("Move");
        rb = Getcomponent<Rigidbody>();
    }

    void Update()
    {
        moveLeftorRight();

    }

    private void moveLeftorRight()
    {
        moveValue = moveAction.ReadValue<Vector2>();
        rb.AddForce(new Vector3(moveValue.x, 0, 0) * forcePower);
    }
}
