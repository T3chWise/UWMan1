using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehavior
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput=0, yInput=0;
        yInput += Input.GetAxis("Vertical");
        xInput += Input.GetAxis("Horizontal");
        transform.Translate()
    }
}
