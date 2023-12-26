
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viên_đạn : MonoBehaviour
{
  
  
    public float speed_đạn;
    Rigidbody2D  rb_dan ;
    
  
    private dichuyen player; // Thêm biến player để tham chiếu đến đối tượng dichuyen
 
    // Start is called before the first frame update
    void Start()
    {
        rb_dan =GetComponent<Rigidbody2D> ();
         player = FindObjectOfType<dichuyen>(); // Tìm đối tượng dichuyen trong scene
    }

    // Update is called once per frame
    void Update()
    {
        // Vecto2 = (0,1);
        rb_dan.velocity = Vector2.up*speed_đạn;
  
    }
 private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("diabay"))
        {
            
            Destroy(other.gameObject);
            Destroy(gameObject);
           
            // Gọi phương thức ScoreIncrement() để cộng điểm
            if (player != null)
            {
                player.ScoreIncrement();
                 
                Debug.Log("điểm "+player.Score);
            }
        }
    }
}
