using UnityEngine;
using UnityEngine.InputSystem;

public class player_mover_scr : MonoBehaviour

{
    public float moveInput = 3f;
    void start()
    {

    }
    void update()
    {
         if (Mouse.current.leftButton.isPressed)  {
            Debug.Log("test");
      }

if (Keyboard.current.wKey.isPressed){ 
 Debug.Log("test");
}
}
}