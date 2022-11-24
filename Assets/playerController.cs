using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//[RequireComponent(typeof(Rigidbody))]

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpForce = 500.0f;

    private CharacterController _body;

    public bool onGround = false;


    void Start()
    {
        _body = GetComponent<CharacterController>();
        jumpActionReference.action.performed += OnJump;
    }

    // Update is called once per frame
    void Update()
    {
        onGround = _body.isGrounded;
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        Debug.Log("jump");
        if (_body.isGrounded) _body.Move(Vector3.up * jumpForce);

    }
}
