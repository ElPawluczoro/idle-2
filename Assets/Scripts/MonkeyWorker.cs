using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MonkeyWorker : MonoBehaviour
{

    private Animator anim;
    private Rigidbody2D workerBody;
    private SpriteRenderer sr;

    private float velocity;


    /*   private void OnTriggerEnter2D(Collider2D collision)
       {
           if (collision.CompareTag("takeBananaPoint"))
           {
               workerBody.velocity = new Vector2(0, 0);
               anim.SetBool("workerWalkEmpty", false);
               anim.SetBool("collect", true);
               Thread.Sleep(1000);
               anim.SetBool("collect", false);
               anim.SetBool("workerWalkFull", true);
               workerBody.velocity = new Vector2(2, 0);
           }
           else if (collision.CompareTag("collectorPoint"))
           {
               anim.SetBool("workerWalkFull", false);
               anim.SetBool("workerWalkEmpty", true);
               workerBody.velocity = new Vector2(-2, 0);

           }
       }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("takeBananaPoint"))
        {
            anim.SetBool("workerWalkEmpty", false);
            anim.SetBool("workerWalkFull", true);
            sr.flipX = true;
            workerBody.velocity = new Vector2(velocity, 0);
        }
        else if (collision.CompareTag("collectorPoint"))
        {
            anim.SetBool("workerWalkFull", false);
            anim.SetBool("workerWalkEmpty", true);
            sr.flipX = false;
            workerBody.velocity = new Vector2(-velocity, 0);

        }
    }

    



    private void Awake()
    {
        velocity = Random.Range(1.5f, 4.0f);
        anim = GetComponent<Animator>();
        workerBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        workerBody.velocity = new Vector2(-velocity, 0);
        //anim.SetBool("workerWalkEmpty", false);
        //anim.SetBool("workerWalkFull", false);
        //anim.SetBool("collect", false);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
