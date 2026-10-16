
using UnityEngine;
using UnityEngine.InputSystem;

public class AirPlaneController : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float turnSpeed = 60f;

    private void Update()
    {
        if (Keyboard.current == null)
            return;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(
                Vector3.back * moveSpeed * Time.deltaTime,
                Space.Self
            );
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(
                Vector3.forward * moveSpeed * Time.deltaTime,
                Space.Self
            );
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Rotate(
                Vector3.up,
                -turnSpeed * Time.deltaTime,
                Space.World
            );
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Rotate(
                Vector3.up,
                turnSpeed * Time.deltaTime,
                Space.World
            );
        }
    }
}
