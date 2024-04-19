using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
     private Inventory<ItemBase> inventory;

    [Header("References")]
    public Camera playerCamera;

    [Header ("General")]
    public float gravityScale = -20f;

    [Header("Movement")]
    public float walkSpeed = 8f;
    public float runSpeed = 16f;

    [Header("Rotation")]
    public float rotationSensitivity = 210f; //A mejorar

    [Header("Jump")] //A mejorar
    public float jumpHeight = 2.5f;

    private float cameraVerticalAngle;
    Vector3 moveInput = Vector3.zero;
    Vector3 rotationInput = Vector3.zero;
    CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

      void Start()
    {
        inventory = new Inventory<ItemBase>();
    }

    private void Update()
    {
        Look();
        Move();
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            ItemBase item = collision.gameObject.GetComponent<ItemBase>(); // Convertir el objeto a tipo T
            if (item != null)
            {
                inventory.AddItem(item);
                Destroy(collision.gameObject); // Eliminar el objeto del juego
            }
        }
    }

      public void UseItem(string itemName)
    {
        ItemBase item = inventory.GetItem(itemName);
        if (item != null)
        {
            item.Use(); // Usar el objeto
        }
    }

    private void Move()
    {
        if (characterController.isGrounded)
        {
            moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveInput = Vector3.ClampMagnitude(moveInput, 1f);

            if (Input.GetButton("Sprint"))
            {
                moveInput = transform.TransformDirection(moveInput) * runSpeed;
            }
            else
            {
                moveInput = transform.TransformDirection(moveInput) * walkSpeed;
            }

            if (Input.GetButtonDown("Jump"))
            {
                moveInput.y = Mathf.Sqrt(jumpHeight * -2f * gravityScale);
            }
        }

        moveInput.y += gravityScale * Time.deltaTime;
        characterController.Move(moveInput * Time.deltaTime);
    }

    private void Look()
    {
        rotationInput.x = Input.GetAxis("Mouse X") * rotationSensitivity * Time.deltaTime;
        rotationInput.y = Input.GetAxis("Mouse Y") * rotationSensitivity * Time.deltaTime;

        cameraVerticalAngle = cameraVerticalAngle + rotationInput.y;
        cameraVerticalAngle = Mathf.Clamp(cameraVerticalAngle, -60, 60);

        transform.Rotate(Vector3.up * rotationInput.x);
        playerCamera.transform.localRotation = Quaternion.Euler(-cameraVerticalAngle, 0f, 0f);
    }
}
