using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject LoosePanel;
    public GameObject WinPanel;
    void Start()
    {
        LoosePanel.SetActive(false);
        WinPanel.SetActive(false);
    }


    public void Loose()
    {
        LoosePanel.SetActive(true);
    }
    public void Win()
    {
        WinPanel.SetActive(true);
    }
    // Update is called once per frame
    public void Next()
    {
        GameManager.instance.CurrentLevel++;
        SceneManager.LoadScene(GameManager.instance.CurrentLevel);
        
    }
    void Update()
    {
        
    }
}
