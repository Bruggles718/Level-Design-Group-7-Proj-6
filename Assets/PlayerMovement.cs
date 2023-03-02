using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float x = 0;
    private float z = 0;

    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float gravity = -9.81f;


    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        this.x = Input.GetAxis("Horizontal");
        this.z = Input.GetAxis("Vertical");

        Vector3 move = this.transform.right * this.x + this.transform.forward * this.z;
        this.controller.Move(move * speed * Time.deltaTime);

        this.velocity.y += this.gravity * Time.deltaTime;

        this.velocity.y = Mathf.Max(this.velocity.y, -100f);

        this.controller.Move(velocity * Time.deltaTime);

        
    }
}
