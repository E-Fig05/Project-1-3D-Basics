using UnityEngine;

public class FPSInput : MonoBehaviour
{
    [SerializeField]
    private float speed = 6.0f;

    [SerializeField]
    private float gravity = -9.8f;

    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);

        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        
        movement = transform.TransformDirection(movement);
        characterController.Move(movement);

    }
}
