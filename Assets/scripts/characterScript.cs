using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class characterScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigid;
    float axis;
    public GameObject cam;

    
    void Update()
    {
        axis = Input.GetAxis("Horizontal");

        rigid.velocity = new Vector2(axis * speed,rigid.velocity.y);

        cameraFollow();
    }

    void cameraFollow()
    {
        if (cam.transform.position.y<transform.position.y)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, transform.position.y, cam.transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="die")
        {
          SceneManager.LoadScene(0);
        }
    }
}
