using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{
    private Animator animator;
    public float countdown;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Chicken"))
        {
            animator.SetTrigger("Destroy");
            EffectSound.BallBounceEffectPlay();
            Destroy(gameObject, countdown);
        }
    }
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
