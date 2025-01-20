using UnityEngine;
using UnityEngine.InputSystem;

public class Yuuka : MonoBehaviour
{
    InputAction yes;
   [SerializeField]  Rigidbody rigi;
    [SerializeField] float Speed;

    void Start()
    {
        yes = InputSystem.actions.FindAction("Move");
        rigi = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigi.linearVelocity = new Vector3(yes.ReadValue<Vector2>().x * Speed, rigi.linearVelocity.y ,yes.ReadValue<Vector2>().y * Speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
