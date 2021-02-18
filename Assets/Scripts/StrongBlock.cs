using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongBlock : MonoBehaviour
{
    Manager manager;
    [SerializeField] int hitsToDestroy = 2;
    private int numberOfHits;

    private void Start()
    {
        manager = FindObjectOfType<Manager>();
        manager.CountBlocksLeft();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        numberOfHits++;
        if (numberOfHits == hitsToDestroy)
        {
            Destroy(gameObject);
            manager.BlockDestroyed();
        }
    }
}
