using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke("Tuhoa", 1f);
        }
    }

    private void Tuhoa()
    {
        Rigidbody2D.Destroy(gameObject);
    }
}
