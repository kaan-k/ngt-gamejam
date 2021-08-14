using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;


    public float PlayerSpeed;
    public float JumpHeight;

    void Start()
    {
       controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * PlayerSpeed);

    }
}
