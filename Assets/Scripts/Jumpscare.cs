using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject jumpscare;
    public GameObject levelText;
    public AudioSource source;
    public AudioClip jumpScareSound;
    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("RedBlock"))
        {
            jumpscare.SetActive(true);
            levelText.SetActive(false);
            source.clip = jumpScareSound;
            source.Play();
            

        }
    }
}
