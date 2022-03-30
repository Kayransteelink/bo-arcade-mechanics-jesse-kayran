using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 3;
    private Animator animator;
    public float speed;
    public float rotationSpeed;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", 0);
        if(Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("Speed", 1);
            transform.position += new Vector3(-movementSpeed, 0, 0) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("Speed", 1);
            transform.position += new Vector3(movementSpeed, 0, 0) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("Speed", 1);
            transform.position += new Vector3(0, 0, movementSpeed) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("Speed", 1);
            transform.position += new Vector3(0, 0, -movementSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetFloat("Speed", 2);
            transform.position += new Vector3(0, 0, movementSpeed * 1) * Time.deltaTime;
        }
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Z)){
            animator.SetTrigger("Happy");
        }
        if (Input.GetKeyDown(KeyCode.X)){
            animator.SetTrigger("relaxed");
        }
        if (Input.GetKeyDown(KeyCode.V)){
            animator.SetTrigger("scared");
        }
        if (Input.GetKeyDown(KeyCode.C)){
            animator.SetTrigger("battle");
        }
        if (Input.GetKeyDown(KeyCode.B)){
            animator.SetTrigger("victory");
        }
    }
}
