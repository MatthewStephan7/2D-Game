using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSound;
    public static AudioClip hitSound;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jump");
        hitSound = Resources.Load<AudioClip>("hit");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
                audiosrc.PlayOneShot(jumpSound);
                break;
            case "hit":
                audiosrc.PlayOneShot(hitSound);
                break;

        }
    }
}
