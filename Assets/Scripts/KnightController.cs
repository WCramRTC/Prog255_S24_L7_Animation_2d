using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightController : MonoBehaviour
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
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
   

        Vector2 movment = new Vector2(horizontal, vertical);
        transform.Translate(movment * Time.deltaTime * speed );

        bool isRunning = horizontal != 0;
        animator.SetBool("isMoving", isRunning);

    }
}
