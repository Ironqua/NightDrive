using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMechanics : MonoBehaviour
{
    [SerializeField] private float defaultSpeed = 6f;
    [SerializeField] private float verticalSpeed;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] AudioSource carEngineStartAudioSource;

    private float verticalMovement;
    private float horizontalMovement;
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        carEngineStartAudioSource.Play();
    }

    private void Update()
    {
        #region carmovement
        verticalMovement = Input.GetAxis("Vertical");
         horizontalMovement = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector3(horizontalMovement * 50 * horizontalSpeed * Time.deltaTime,
                                    defaultSpeed + verticalMovement * 50 * verticalSpeed * Time.deltaTime,
                                    0);


     
        

     if (transform.position.x > 1.65)
        {
            Destroy(this.gameObject);
        }

     if (transform.position.x < -1.65)
        {
            Destroy (this.gameObject);
        }
        #endregion
    }


    
}
