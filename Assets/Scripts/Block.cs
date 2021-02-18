using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Manager manager;

    private void Start()
    {
        manager = FindObjectOfType<Manager>();
        manager.CountBlocksLeft();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        manager.BlockDestroyed();
    }
}
