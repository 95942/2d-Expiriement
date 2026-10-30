using UnityEngine;

public class player_mover_scr : MonoBehaviour

{
    private float moveSpeed = 3f;
    void start()
    {

    }
    void update()
    {
if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position += transform.right * -moveSpeed * Time.deltaTime;
        }

if (Input.GetKey(KeyCode.D))
        { 
            transform.position = transform.position += transform.right * moveSpeed * Time.deltaTime;
        }

    }
}