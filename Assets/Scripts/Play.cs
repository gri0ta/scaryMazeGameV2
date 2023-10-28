using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject StartScreen;

    public string nextSceneName;

    private void Start()
    {
        StartScreen.SetActive(true);
    }
    private void OnMouseDown()
    {
        transform.position += Vector3.down * 0.1f;

    }

    private void OnMouseUp()
    {
        StartScreen.SetActive(false);

        transform.position += Vector3.up * 0.1f;

        if (nextSceneName != "")
        {
            SceneManager.LoadScene(nextSceneName);
        }
        
    }
}