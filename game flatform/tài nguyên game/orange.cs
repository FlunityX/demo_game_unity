using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oranger : MonoBehaviour
{
    private int strawberries = 0;
[SerializeField] private AudioSource tingeffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("straw"))
        {
             tingeffect.Play();
            strawberries++;
            Destroy(collision.gameObject);
            Debug.Log("oranges " + strawberries);
        }
    }
}
