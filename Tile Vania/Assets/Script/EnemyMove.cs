﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    Rigidbody2D myRigidBody;    
    
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (IsFacingRight())
        {
            myRigidBody.velocity = new Vector2(speed, 0f);
        }
        else
        {
            myRigidBody.velocity = new Vector2(-speed, 0f);
        }
        
    }

    bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {        
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.velocity.x)), 1f);
    }
}