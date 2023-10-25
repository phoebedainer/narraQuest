﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    private float _nextHit = 0.15f;

    public bool flipCharacter = false;
    private bool m_facingRight = true;
    private void Flip()
    {
        // Switch the way the enemy is labelled as facing.
        m_facingRight = !m_facingRight;

        // Multiply the enemy's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Time.time > _nextHit)
        {
            Debug.Log($"{name} Triggered");
            FindObjectOfType<LifeCount>().LoseLife();
            _nextHit = Time.time + 0.5f;
        }
    }
}
