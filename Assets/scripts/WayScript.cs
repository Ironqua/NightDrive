using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject wayprefab;
    bool waycontrol;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="mainCar"&& waycontrol==false) { 
            Vector3 spawnpoint = new Vector3(transform.position.x, transform.position.y + 8, 0f);
        Instantiate(wayprefab, spawnpoint, Quaternion.identity);

            GameManager.score += 10;

            Destroy(wayprefab, 7f);
            waycontrol = true;
    }
    }


}
