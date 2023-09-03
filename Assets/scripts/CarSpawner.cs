using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] carprefab;

    bool spawn;

    float cooldown = 1f;
    void Start()
    {
       
        StartCoroutine(spawner());
    }

     IEnumerator spawner()
    {

      while (true)
        {
             int randomIndex = Random.Range(0, carprefab.Length);
            Instantiate(carprefab[randomIndex],transform.position, Quaternion.Euler(0f,0f,90f));
            yield return new WaitForSeconds(cooldown);
            
        }

    }
}
