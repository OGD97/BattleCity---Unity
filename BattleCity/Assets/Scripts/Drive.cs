using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
       
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

      
        transform.Translate(0, translation, 0);
        transform.Rotate(0, 0, -rotation);
    }
}