using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 80f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 mousePos = Input.mousePosition;

        if (GameManager.instance.isGameOver)
            return;

        if (Input.touchCount > 0)
        {
            if (mousePos.x < 370)
            {
                transform.Rotate( Vector3.up, +rotationSpeed * Time.deltaTime);

            }
            if (mousePos.x > 370)
            {
                transform.Rotate( Vector3.up, -rotationSpeed * Time.deltaTime);

            }
        }
    }
}
