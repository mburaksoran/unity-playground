using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody2D rigidB; 
    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");

        rigidB.velocity = new Vector2(dirX * 7f, rigidB.velocity.y);
        
        if (Input.GetButtonDown("Jump"))
        {
         

                rigidB.velocity = new Vector2(rigidB.velocity.x, 14f);  


        }
    }
}
