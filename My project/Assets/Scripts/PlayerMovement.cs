using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float jumpForce = 5f;
    public float slideSpeed = 8f;
    public float slideDuration = 1f;
    private float normalSpeed;


    private Rigidbody2D rb;

    private Animator animator;

    private bool isGrounded = true;
    private bool isSliding = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        normalSpeed = playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            animator.Play("Jump");
            //animator.SetBool("isJumping", true);
        }

        if (Input.GetKeyDown(KeyCode.S) && isGrounded && !isSliding)
        {
            isSliding = true;
            playerSpeed = slideSpeed;
            animator.SetBool("isSliding", true);
            StartCoroutine(StopSlidingAfterDuration());
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            //animator.SetBool("isJumping", false);
        }
    }

    private IEnumerator StopSlidingAfterDuration()
    {
        yield return new WaitForSeconds(slideDuration);
        isSliding = false;
        playerSpeed = normalSpeed;
        animator.SetBool("isSliding", false);
    }
}
