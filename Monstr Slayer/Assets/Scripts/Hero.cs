using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private int speed = 3;
    private int life = 3;
    private int kdm1 = 3;
    private int kdm2 = 3;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.right = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
    }   
}
