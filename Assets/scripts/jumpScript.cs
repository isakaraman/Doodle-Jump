using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{
    public float jumpForce;
    Vector2 jumpSpeed;
    Rigidbody2D rigid;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigid = collision.collider.GetComponent<Rigidbody2D>();

        if (collision.relativeVelocity.y<=0)
        {
            if (rigid != null)
            {
                //jumpSpeed = rigid.velocity;
                //jumpSpeed.y=jumpForce;
                rigid.velocity = new Vector2(0, jumpForce);
            }
        }

    }
}
