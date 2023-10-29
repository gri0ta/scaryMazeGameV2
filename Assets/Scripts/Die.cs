using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    //public GameObject jumpscare;
    
    

    public string nextSceneName = "Level1";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Wall"))
        {
            SceneManager.LoadScene(nextSceneName);
        }
            
    }
}
