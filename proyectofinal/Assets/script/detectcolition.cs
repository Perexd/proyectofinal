using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectcolition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (gameObject.CompareTag("obstaculo") && otherCollider.gameObject.CompareTag("player"))
        {
            Time.timeScale = 0;
            Debug.Log("Game over");
        }
        if (gameObject.CompareTag("proyectil") && otherCollider.gameObject.CompareTag("obstaculo"))
        {
            Destroy(gameObject);
        }
    }
}
