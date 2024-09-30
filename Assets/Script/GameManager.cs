using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 Pod;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(Pod);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            rb.AddForce(new Vector2(-100, 0));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)){
            rb.AddForce(new Vector2(100, 0));
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)){
            rb.AddForce(new Vector2(0, 100));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            rb.AddForce(new Vector2(0, -100));
        }

        if(Input.GetKeyDown(KeyCode.Tab)){
            rb.gravityScale = rb.gravityScale * -1;
        }

        Debug.Log(rb.velocity);
    }

    
}
