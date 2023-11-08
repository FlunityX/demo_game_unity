using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private LayerMask jumpable;
    // Khai báo thuộc tính
    public Rigidbody2D rb;
    
    public bool duocphepnhay = false;
    public float dirX = 0;
    public Animator anim;
    public SpriteRenderer sprite;
    [SerializeField] public AudioSource jumpeffect;

 

    // Start is called before the first frame update
    void Start()
    {
        // Thay tên thuộc tính
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && duocphepnhay)
        {
            jumpeffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, 8);
            
            duocphepnhay = false;
            anim.SetTrigger("jump");
        }

        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }

        if (!duocphepnhay && rb.velocity.y <= 0)
        {
            duocphepnhay = true;
        }
        if(rb.velocity.y > 0 )
        {
            duocphepnhay =false;
        }
    }
}