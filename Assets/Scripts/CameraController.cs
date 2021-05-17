using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Target;

    [SerializeField]
    float limit;
    [SerializeField]
    float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (GameManager.instance.isGameOver)
            return;
        Vector3 vect = new Vector3(transform.position.x, Target.transform.position.y +offset, transform.position.z);
        if(transform.position.y > limit - offset)
        this.transform.position = vect;

    }
}
