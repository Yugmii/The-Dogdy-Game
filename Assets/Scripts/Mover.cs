using UnityEngine;
using UnityEngine.InputSystem;
public class Mover : MonoBehaviour
{
    [SerializeField] int moveSpeed = 10;
    
       void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }

        if (Keyboard.current.sKey.isPressed)
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);

        if (Keyboard.current.aKey.isPressed)
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);

        if (Keyboard.current.dKey.isPressed)
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);

        // float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // float yValue = 0f;
        // transform.Translate(xValue, yValue, zValue);
    }
}