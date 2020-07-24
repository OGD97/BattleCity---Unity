using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float translateX = Input.GetAxis("Horizontal");
        float translateY = Input.GetAxis("VerticalY");
        float translateZ = Input.GetAxis("Vertical");

        this.transform.Translate(translateX, 0,0);
        this.transform.Translate(0, translateY,0);
        this.transform.Translate(0, 0, translateZ);

    }
}
