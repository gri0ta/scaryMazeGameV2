using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject jumpscare;
    public GameObject levelText;
    AudioSource source;
    public AudioClip jumpScareSound;
    
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Teleporter"))
        {
            jumpscare.SetActive(true);
            levelText.SetActive(false);
            source.Play();

        }
    }
}
