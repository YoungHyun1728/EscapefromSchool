using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    Rigidbody2D p_rigid2D;
    CapsuleCollider2D capsuleCollider;
    SpriteRenderer spriteRenderer;
    Animator anim;
    
    static public bool clear = false;
    static public bool isdead = false;

    public float speed = 15f;

    void Start()
    {
        p_rigid2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        anim = GetComponent<Animator>();
        clear = false;
        isdead = false;
    }

    
    void Update()
    {
        
        // ���콺 ������ ��ġ
        Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, Input.mousePosition.z));

        Vector2 MovePos = (point - transform.position).normalized;

        transform.Translate(MovePos * Time.deltaTime * speed);


    
    
        //ī�޶� ������ �̵� ����
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;

        transform.position = Camera.main.ViewportToWorldPoint(pos);

        //����ũ ����
        if(point.x > transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        if (point.x < transform.position.x)
        {
            spriteRenderer.flipX = false;
        }



        if (Input.GetKey(KeyCode.Mouse1))
        {
            ClearStage();
        }
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("����");
            isdead = true;
        }

        if (collision.gameObject.tag == "goal")
        {
            ClearStage();
        }

    }

    public void ClearStage()
    {
        Debug.Log("Ŭ����");
        clear = true;
    }
}
