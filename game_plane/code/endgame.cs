using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public GameObject maybay;
    int solancham = 0 ;
    private void Start() {
    maybay = FindObjectOfType<GameObject>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("diabay")){
            
            solancham++;
            Debug.Log("so lan :" + solancham);
            if (solancham >=3 ){
                SceneManager.LoadScene(1);
                return;
            }
        }
    }
}
