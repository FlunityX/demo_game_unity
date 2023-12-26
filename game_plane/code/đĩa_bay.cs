
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class đĩa_bay : MonoBehaviour
{
    public Rigidbody2D rb_diabay;
    // Start is called before the first frame update
    void Start()
    {
        rb_diabay = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb_diabay.velocity =new UnityEngine.Vector2(UnityEngine.Random.Range(-7.8f,7.8f),0);
    }
}
