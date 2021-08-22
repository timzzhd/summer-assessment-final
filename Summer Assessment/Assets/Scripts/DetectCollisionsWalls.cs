using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisionsWalls : MonoBehaviour
{
    public static int coinAmount;
    
    void Start()
    {
        
    }

    
    void Update()
    {
      
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        SceneManager.LoadScene("Loser");
    }
}
