using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    
    
    
    public float GetCSpeed()
    {
        return Currentspeed;
    }
    
    //Movemet 
    public Rigidbody playerRb;
    public float Speed = 100f;
    public float maxSpeed = 50f;
    
    
    //CurrentSpeed Function
    public float Currentspeed;
    public Text SpeedDebug;
    

    void Start()
    {
        StartCoroutine(CalcSpeed());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRb.AddForce(transform.forward * Speed);
        }

        if (Currentspeed > maxSpeed)
        {
             
             playerRb.velocity = playerRb.velocity.normalized * (maxSpeed - 2f);
        }
        


    }

    
        IEnumerator CalcSpeed()
        {
            bool isPlaying = true;
    
            while (isPlaying)
            {
                Vector3 prevPos = transform.position;
    
                yield return new WaitForFixedUpdate();
    
                Currentspeed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);

                if (Currentspeed > maxSpeed)
                {
                    SpeedDebug.text = "Speed: " + maxSpeed.ToString();
                }
                else
                {
                    SpeedDebug.text = "Speed: " + Currentspeed.ToString();
                }
                
            }
        }
}


