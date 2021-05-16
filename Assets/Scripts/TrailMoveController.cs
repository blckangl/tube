using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailMoveController : MonoBehaviour
{
    public Transform Tube;

    public GameManager.color color;
 
    [SerializeField]
    float speed = 5.5f;
    [SerializeField]
    float rotationSpeed = 80f;


    TrailRenderer trailRenderer;
    // Start is called before the first frame update
    void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        //trailRenderer.endColor = trailColor;
    }

    // Update is called once per frame
    void Update()
    {


        if (GameManager.instance.isGameOver)
            return;
        transform.position -= Vector3.up * speed*Time.deltaTime;

    }

    void LateUpdate()
    {
        Vector3 mousePos = Input.mousePosition;

        if (GameManager.instance.isGameOver)
            return;

         if(Input.touchCount > 0)
        {
            if (mousePos.x < 370)
            {
                transform.RotateAround(Tube.position, Vector3.up, +rotationSpeed * Time.deltaTime);

            }
            if (mousePos.x > 370)
            {
                transform.RotateAround(Tube.position, Vector3.up, -rotationSpeed * Time.deltaTime);

            }
        }
        
    }
}
