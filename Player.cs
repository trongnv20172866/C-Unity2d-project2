using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumForce;
    Rigidbody2D m_rb; // tham chieu den rgb2d dat ten la m_rb;
    bool m_isGround;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>(); //tham chieu
    }

    // Update is called once per frame
    void Update()
    {
        bool isJumpKeyPressed = Input.GetKeyDown(KeyCode.Space);

        if(isJumpKeyPressed && m_isGround)
        {   //Vector2.up = (0,1)
            //(0,1)*5=(0,5)
            m_rb.AddForce(Vector2.up * jumForce);
            m_isGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D col) //bat va cham giua cac doi tuong game khong di xuyen qua nhau
    {
        if(col.gameObject.CompareTag("Ground"))
        {
            m_isGround = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Obstacle"))
        {
            Debug.Log("va cham");
        }
    }

}
