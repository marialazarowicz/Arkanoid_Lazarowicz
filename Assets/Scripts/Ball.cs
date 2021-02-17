using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    bool hasStarted = false;
    [SerializeField] float pushUp = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            launchOnEnter();
        }
        
    }

    private void launchOnEnter()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, pushUp);
            }
    }
}
