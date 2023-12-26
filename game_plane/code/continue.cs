using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuegame : MonoBehaviour
{
   public void _continue()
   {
    SceneManager.LoadScene(0);
   }
   public void thoat(){
    Application.Quit();
   }
}
