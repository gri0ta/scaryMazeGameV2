using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject jumpscare;
    public GameObject levelText;
    public AudioSource source;
    public AudioClip jumpScareSound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
