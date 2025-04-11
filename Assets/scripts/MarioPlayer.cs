using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioPlayer : MonoBehaviour
{

    public float speed = 5.0f;
    
    private Rigidbody2D _rigidbody2D;

    
    
    
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
       float inputHorizontal = Input.GetAxisRaw("Horizontal");
       _rigidbody2D.velocity = new vector2 (inputHorizontal *, speed*, rigidbody2D.velocity.y);

       float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
       transform.Rotate(0, speed, 0);
    }
}
