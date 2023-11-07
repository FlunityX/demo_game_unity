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

    AnimatorStateInfo stateInfo;

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
        // Input.GetAxis("Horizontal"): Đây là một hàm trong Unity để lấy giá trị 
        // đầu vào từ trục ngang (trái/phải) của bàn phím hoặc thiết bị nhập liệu.
        // Khi nhấn phím mũi tên trái, giá trị sẽ là -1; khi nhấn phím mũi tên phải, 
        // giá trị sẽ là 1; và khi không nhấn phím nào, giá trị sẽ là 0. Điều này cho 
        // phép điều khiển di chuyển sang trái hoặc sang phải.
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