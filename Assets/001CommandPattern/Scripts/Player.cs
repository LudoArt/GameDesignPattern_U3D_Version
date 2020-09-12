using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool faceRight;

    [Range(0, 100)] public float moveSpeed = 1.0f;
    [Range(0, 5)] public float jumpForce = 10.0f;
    public Rigidbody2D myRig;


    #region 角色是否在地面上的判断

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround; 

    #endregion


    private void Start()
    {
        faceRight = true;
        myRig = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            myRig.velocity = Vector2.up * jumpForce;
        }
    }

    public void MoveLeft()
    {
        myRig.velocity = new Vector2(-moveSpeed * Time.deltaTime, myRig.velocity.y);
        if (faceRight)
        {
            Flip();
        }
    }

    public void MoveRight()
    {
        myRig.velocity = new Vector2(moveSpeed * Time.deltaTime, myRig.velocity.y);
        if (!faceRight)
        {
            Flip();
        }
    }

    /// <summary>
    /// 角色转头
    /// </summary>
    private void Flip()
    {
        faceRight = !faceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
