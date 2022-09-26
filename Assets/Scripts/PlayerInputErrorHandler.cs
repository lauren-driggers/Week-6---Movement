using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputErrorHandler : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 forceDirection;
    private PlayerInput Input;
   
    private void Start()
    {
        Input = GetComponent<PlayerInput>();
        rigidbody = GetComponent<Rigidbody>();
    }
 
    private void OnDisable()
    {
        Input.actions = null;
    }

    private void Update()
    {
        rigidbody.AddForce(forceDirection, ForceMode.Impulse);
        // for rotating, can switch to quaternion by: Quaterion.Angle(Vector3)
    }
}
