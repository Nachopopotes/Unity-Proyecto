using UnityEngine;
using UnityEngine.InputSystem;

public class mover2D : MonoBehaviour
{
    public float speed = 1.0f;
    public int fps;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(0, 1);

        if (Keyboard.current.wKey.isPressed)
        {
            dir.y = 1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            dir.y = -1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            dir.x = -1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            dir.x = 1;
        }

        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
