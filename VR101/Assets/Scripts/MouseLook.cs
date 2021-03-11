using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private float sens;

    public Transform characterBody;

    private float Rotation_x = 0f;

    private void Update()
    {
        float Rot_x = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        float Rot_y = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;

        Rotation_x -= Rot_y;

        transform.localRotation = Quaternion.Euler(Rotation_x, 0f, 0f);

        Rotation_x = Mathf.Clamp(Rotation_x, -80f, 80f);

        characterBody.Rotate(Vector3.up * Rot_x);

    }
}
