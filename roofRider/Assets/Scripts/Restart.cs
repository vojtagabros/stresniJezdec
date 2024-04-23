using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    
    
    
    public Rigidbody playerRb;
    public Text GGtext;
    public GameObject RespawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localRotation = Quaternion.Euler(0, -180, 0);
            playerRb.velocity = Vector3.zero;
      
            transform.position = RespawnPoint.transform.position;
            
            
            GGtext.text = "";
            
            
             

        }
    }
}


