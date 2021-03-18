using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller; 
    public float gravity = -9.81f;

    Vector3 velocity;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Movement(x,z);
        Gravity();

    }

    
    private void Movement(float x, float z)
    {
        //karakterin hareket vektörü
        Vector3 move = transform.right * x + transform.forward * z;


        //karakterin hareketi
        float walk_speed = 20f;
        float run_speed = 40f;

        if (Input.GetKey("left shift"))
        {
            controller.Move(move * run_speed * Time.deltaTime);
        }

        controller.Move(move * walk_speed * Time.deltaTime);




    }

    private void Gravity()
    {
        // yer çekimi
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
