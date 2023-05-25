using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glide : MonoBehaviour
{
    public Transform rigRoot;
    public float velocity = 2f; // meters per second
    public float rotationSpeed = 100f;
    private void Start()
    {
        if (rigRoot == null) rigRoot =
        transform;
    }
    private void Update()
    {
        float forward = Input.GetAxis(" XRI_Right_Primary2DAxis_Vertical");
        if (forward != 0f)
        {
            Vector3 moveDirection = Vector3.forward; moveDirection *=
            - forward * velocity
            * Time.deltaTime; rigRoot.Translate(moveDirection);
        }
        
        float sideways = Input.GetAxis("XRI_Right_Primary2DAxis_Horizontal");
        if (sideways != 0f)
        {
                    float rotation = sideways * rotationSpeed
                    * Time.deltaTime;
                    rigRoot.Rotate(0, rotation, 0);
        }
    }
}
