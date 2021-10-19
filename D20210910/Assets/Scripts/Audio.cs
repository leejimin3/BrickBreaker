using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip bgsound;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = gameObject.AddComponent<AudioSource>();
        audiosource.clip = bgsound;
        audiosource.mute = false;
        audiosource.loop = true;
        audiosource.playOnAwake = true;

        audiosource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
