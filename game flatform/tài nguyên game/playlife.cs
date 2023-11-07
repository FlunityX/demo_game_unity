using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using UnityEngine.SceneManagement;

public class playlife : MonoBehaviour
{
    private Rigidbody2D Rb;
    private Animator anim;
[SerializeField ] private AudioSource deathsound;
    void Start()
    {
        Rb=GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
    }
   
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("trap")){
            Die();
        }
    }
    private void Die(){
        deathsound.Play();
        Rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }
    private void restartlevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
