using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class NPCcarMove : MonoBehaviour
{

    Rigidbody2D rb;
    private float movementspeed = 3f;
    float ypoint = 5f;
  [SerializeField]  public AudioSource crashAudio;
    bool alreadyPlayed;

    private float lane;
    void Start()
    {
      
        rb = GetComponent<Rigidbody2D>();
        lane = Random.Range(1, 5);
        randomlane();
       
    }

  
    void Update()
    {
        Destroy(this.gameObject, 15f);
    }
    void FixedUpdate()
    {
        Vector3 newpos = new Vector3(0f, movementspeed *50* Time.deltaTime, 0f);
        rb.velocity = newpos;

    }
    void randomlane()
    {

        if (lane == 1)
        {
            transform.position = new Vector3(-1.25f, transform.position.y+ypoint , 0f);

        }
        else if (lane == 2)
        {
            transform.position = new Vector3(-0.44f, transform.position.y+ypoint, 0f);

        }
        else if (lane == 3)
        {
            transform.position = new Vector3(0.41f, transform.position.y   +ypoint, 0f);

        }
        else if (lane == 4)
        {
            transform.position = new Vector3(1.278f, transform.position.y +ypoint, 0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Left"))
        {
            GameManager.score += 25;
           

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("mainCar"))
        {

            Debug.Log("CRASH;");
        }

        Invoke("LoadEndMenu", 1f);
    }
    private void LoadEndMenu()
    {
        SceneManager.LoadScene("EndMenu");
    }

}
