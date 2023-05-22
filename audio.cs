using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audio : MonoBehaviour

{
    

    GameObject ad;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
