using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        // transform.Rotate(0, Input.GetAxis("Mouse Y") * Time.deltaTime * speed, Input.GetAxis("Mouse X") * Time.deltaTime * speed);

        transform.Translate(xValue, 0, zValue);
    }
}
