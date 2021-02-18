using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour
{
    [SerializeField] int blocksLeft;
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocksLeft()
    {
        blocksLeft++;
    }

    public void BlockDestroyed()
    {
        blocksLeft--;
        if (blocksLeft <=0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
