using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField] private float speed;
    static public float moveToTimer = 0;
    static public Vector3 pos;
    public Animator playerAnimator;

    Rigidbody2D rigidbody2d;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    { 
        moveToTimer -= Time.deltaTime;

        if (moveToTimer > 0)
            transform.position += pos * Time.deltaTime * 4;
        else
            moveToTimer = 0;
    }

}
