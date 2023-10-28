using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject LevelText;
    //public GameObject Button;

    //public string nextSceneName;

    
    private void OnMouseDown()
    {
        transform.position += Vector3.down * 0.1f;

    }

    private void OnMouseUp()
    {
        StartScreen.SetActive(false);
        LevelText.SetActive(true);
        transform.position += Vector3.up * 0.1f;

        
        
    }
}