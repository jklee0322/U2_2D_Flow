using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    Transform Ball;
    CameraShake CS;
    ParticleSystem Effect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Chicken"))
        {
            Ball = collision.transform;
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            CS = GameObject.Find("Background").GetComponent<CameraShake>();
            CS.Shake();
            EffectSound.GoalEffectPlay();
            Effect = GameObject.Find("Effect").GetComponent<ParticleSystem>();
            Invoke("EffectPlay", 0.5f);
            Invoke("Stage", 1.5f);
        }
    }   
    void EffectPlay()
    {
        Effect.transform.position = this.transform.position;
        Effect.transform.localScale =this.transform.localScale* 0.5f;
        Effect.Play();
    }
    void Stage()
    {
        GameObject.Find("Stage").GetComponent<Stage>().IsGameOver(true);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Ball!=null)
        {
            Ball.transform.position = Vector2.Lerp(Ball.position, this.transform.position, 3f * Time.deltaTime);
        }
    }
}
