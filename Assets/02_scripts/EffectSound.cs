using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSound : MonoBehaviour
{
    static AudioSource audioSource;
    public static AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void GoalEffectPlay()
    {
        audioClip = Resources.Load<AudioClip>("GoalEffect");
        audioSource.PlayOneShot(audioClip);
    }
    public static void BallBounceEffectPlay()
    {
        audioClip = Resources.Load<AudioClip>("BounceEffect");
        audioSource.PlayOneShot(audioClip);
    }
}
