using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isGameOver;
    public int CurrentLevel = 0;

 
    public bool NoInput = true;
    public bool isGoalReached = false;

    public enum color
    {
        red,green,blue
    };

    private UiManager uiManager;
    void Start()
    {
        if (GameManager.instance)
        {
            Destroy(this.gameObject);
            return;
        }
        GameManager.instance = this;
        uiManager = GameObject.Find("UiManager").GetComponent<UiManager>();
        isGoalReached = false;
        isGameOver = false;
    }


    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void GoalReached()
    {
        isGoalReached = true;
    }
     void Win()
    {
        isGameOver = true;
        uiManager.Win();
        Debug.Log("Win");
    }
     void Loose()
    {
        isGameOver = true;
        uiManager.Loose();

        Debug.Log("Loose");

    }

    public void EndGame()
    {
        if (isGoalReached)
        {
            Win();
        }
        else
        {
            Loose();
        }
    }
}
