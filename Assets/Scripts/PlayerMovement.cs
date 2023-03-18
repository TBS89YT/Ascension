using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody2D PlayerRig;

    private float horizontal;
    private float vertical;
    public float Speed;
    void Start()
    {

    }
    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        PlayerRig.velocity = new Vector2(Speed * horizontal, Speed * vertical);
    }
}
