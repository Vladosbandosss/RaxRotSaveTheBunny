using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    public GameObject dust;
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Ground"))
        {
           GameObject particleEffect = Instantiate(dust, transform.position, Quaternion.identity);
            GameManager.instanse.IncrementScore();
            Destroy(particleEffect, 3f);
            Destroy(gameObject);
        }
        if (coll.gameObject.CompareTag("Player"))
        {
          
            Destroy(coll.gameObject);
            GameManager.instanse.GameOver();
        }
    }
}
