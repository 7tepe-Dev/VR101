using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitys : MonoBehaviour
{
    public CharacterController controller;
    public float gravity = -9.81f;
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        Gravity();
    }

    private void Gravity()
    {
        // yer çekimi
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
