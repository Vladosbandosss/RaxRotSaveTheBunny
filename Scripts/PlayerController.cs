using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float inputX;
   [SerializeField] float moveSped;

    Vector2 newPosition;

    private float maxXpos = 2.5f;
    private float minXpos = -2.5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        inputX = Input.GetAxis("Horizontal");
        newPosition = transform.position;
        newPosition.x += inputX*moveSped*Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, minXpos, maxXpos);

        rb.MovePosition(newPosition);
    }

}
