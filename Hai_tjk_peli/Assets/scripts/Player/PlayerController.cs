using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 moveInput;
    private Master controls;
    private Rigidbody2D body; 
        
     void Awake() 
    {
        controls = new Master();
        body = GetComponent<Rigidbody2D>();
    }
    private void OnEnable() {
        controls.Enable();
    }
    private void OnDisable() {
        controls.Disable();
    }
    void FixedUpdate() 
    {
        moveInput = controls.player.movement.ReadValue<Vector2>();
        Vector2 Movement = new Vector2(moveInput.x, moveInput.y) * moveSpeed * Time.fixedDeltaTime;
        body.MovePosition(body.position + Movement);
    }
}
