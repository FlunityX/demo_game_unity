using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
public Rigidbody2D rb;
public int tocdo = 4;
public bool flip;
public float traiphai;
public bool isfacingright = true;
public bool isattacking = false;
public bool skill1= false;
public bool skill2= false;
public bool skill3=false;
public bool stun=false;
public bool die=false;
public bool chuyendoi=false;
public float jumpforce=20f;
public bool danhay= false;
public bool duocphepnhay =false;
Animator animator;
Animator anim;


AnimatorStateInfo stateInfo; // thêm biến stateInfo

void Start()
{
    animator = GetComponent<Animator>();
}

void Update()
{
    traiphai = Input.GetAxisRaw("Horizontal");
    rb.velocity = new Vector2(traiphai * tocdo, rb.velocity.y);
    if (isfacingright == true && traiphai == -1)
    {
        transform.localScale = new Vector3(-1, 1, 1);
        isfacingright = false;
    }
    if (isfacingright == false && traiphai == 1)
    {
        transform.localScale = new Vector3(1, 1, 1);
        isfacingright = true;
    }
    animator.SetFloat("dichuyen", Mathf.Abs(traiphai));
   if (Input.GetKeyDown(KeyCode.Space)&& duocphepnhay && ! danhay)
   {
       danhay=true;
       rb.AddForce(Vector2.up*jumpforce,ForceMode2D.Impulse);
       animator.SetTrigger("nhay");
       animator.Play("jump");
   }
 if (duocphepnhay && rb.velocity.y <= 10)
{
danhay = false;
duocphepnhay = true;
}
else
{
danhay = true;
duocphepnhay = false;
}
stateInfo = animator.GetCurrentAnimatorStateInfo(0); // lấy thông tin trạng thái hiện tại
if (Input.GetKeyDown(KeyCode.Return))
{
animator.Play("attack");
}
if (Input.GetKeyDown(KeyCode.Alpha1))
{
animator.Play("skill1");
}
if (Input.GetKeyDown(KeyCode.Alpha2))
{
animator.Play("skill2");
}
if (Input.GetKeyDown(KeyCode.Alpha3))
{
animator.Play("skill3");
}
if (Input.GetKeyDown(KeyCode.Alpha0))
{
animator.Play("stun");
}
if (Input.GetKeyDown(KeyCode.Alpha4))
{
animator.Play("die");
}


}

public void OnAttackAnimationEnd()
{
    if (stateInfo.IsName("attack") && stateInfo.normalizedTime >= 1.0f)
    {
        isattacking = true;
        animator.Play("run");
    }
}

public void Onskill1AnimationEnd()
{
    if (stateInfo.IsName("skill1") && stateInfo.normalizedTime >= 1.0f)
    {
        skill1 = true;
        animator.Play("run");
    }
}

 public void Onskill2AnimationEnd()
{
    if (stateInfo.IsName("skill2") && stateInfo.normalizedTime >= 1.0f)
    {
        skill2 = true;
        animator.Play("run");
    }
}
  public void Onskill3AnimationEnd()
{
    if (stateInfo.IsName("skill3") && stateInfo.normalizedTime >= 1.0f)
    {
        skill3 = true;
        animator.Play("run");
    }
}
      public void OnstunAnimationEnd()
{
    if (stateInfo.IsName("stun") && stateInfo.normalizedTime >= 1.0f)
    {
        stun = true;
        animator.Play("run");
    }
}
   public void OndieAnimationEnd()
{
    if (stateInfo.IsName("die") && stateInfo.normalizedTime >= 1.0f)
    {
        die = true;
        animator.Play("run");
    }
    
}}