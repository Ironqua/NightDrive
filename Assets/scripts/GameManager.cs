using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoretext;
    public static float score;
    void Start()
    {
        score = 0;        
    }

    // Update is called once per frame
    void Update()
    {
       
        scoretext.text=score.ToString();
    }
}
