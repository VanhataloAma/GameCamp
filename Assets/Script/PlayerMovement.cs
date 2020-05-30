using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting Position: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementVector = new Vector3(0.05f, 0, 0);
        transform.Translate(movementVector);

        Debug.Log("Current Position: " + transform.position);
    }
}
