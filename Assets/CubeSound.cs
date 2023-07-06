using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    public AudioClip block;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("CubePrefabTag") || collision.gameObject.CompareTag("GroundTag"))
        {
            Debug.Log("ok");
            audioSource.PlayOneShot(audioSource.clip);
        }
           
    }
}
