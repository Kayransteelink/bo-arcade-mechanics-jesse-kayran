using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 3;
    private Animator animator;
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
    }
}
