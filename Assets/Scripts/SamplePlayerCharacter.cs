using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Sample character script demonstrating how to send inputs to a motor
/// </summary>
public class SamplePlayerCharacter : MonoBehaviour
{
    [SerializeField] PlayerInput playerInput;
    // The motor we're controlling
    [Header("Motor references")]
    public KinematicPlayerMotor motor;
    public Animator animator;
    public Rigidbody rigidbody;


    private void Start()
    {
    }
    private void Update()
    {
        
        
            Vector2 moveInput = playerInput.currentActionMap["Move"].ReadValue<Vector2>();

            Vector3 newMovInp = new Vector3(moveInput.x, 0, moveInput.y);
            // send inputs to motor
            motor.MoveInput(newMovInp);
            if (playerInput.currentActionMap["Jump"].ReadValue<float>() == 1)
            {
                motor.JumpInput();

            }              
            
            
            Vector2 lookInput = playerInput.currentActionMap["Look"].ReadValue<Vector2>();
            
    } 
}