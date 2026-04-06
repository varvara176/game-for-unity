using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 input;

    void Update()
    {
        if (Keyboard.current.iKey.isPressed) input.y = 1f;
        else if (Keyboard.current.kKey.isPressed) input.y = -1f;
        else input.y = 0f;
        if (Keyboard.current.lKey.isPressed) input.x = 1f;
        else if (Keyboard.current.jKey.isPressed) input.x = -1f;
        else input.x = 0f;
        transform.Translate(input * speed * Time.deltaTime);
    }
}