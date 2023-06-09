using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMovementCtrl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX, moveY;
    private PAnimationCtrl playerAnimation;
    public float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = FindObjectOfType<PAnimationCtrl>();
    }

    private void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 currentPos = rb.position;
        Vector2 inputVector = new Vector2(moveX, moveY).normalized * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(currentPos + inputVector);

        playerAnimation.SetDirection(new Vector2(moveX, moveY));
    }
}
