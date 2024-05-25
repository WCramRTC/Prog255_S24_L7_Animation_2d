using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 1;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement for our main character
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        transform.Translate(movement * Time.deltaTime * speed);

        // Trigger Animations based on movement
        // Write the code that triggers our walk down animation when we press down
        // OR when y is negative
        animator.SetFloat("isMovingDown", vertical);
        animator.SetFloat("isMovingRight", horizontal);

        Debug.Log($"x: {horizontal} - y: {vertical}");
    }
}
