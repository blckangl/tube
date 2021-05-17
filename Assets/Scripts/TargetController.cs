using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameManager.color color;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("target");

        TrailMoveController trailCtrl = other.gameObject.GetComponent<TrailMoveController>();

        if (trailCtrl)
        {
            if (trailCtrl.color == color)
            {
                GameManager.instance.GoalReached();
            }
           
        }
    }
}
