using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePassedMenu : MonoBehaviour
{

    public GameObject missionCompletedMenu; // assign
    public static bool isOver = false;
    private HealthScript healthScript;
    // Start is called before the first frame update
    void Start()
    {
        missionCompletedMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (healthScript.isCompleted)
        {
           StopGame();
        }
    }

     public void StopGame()
    {
        missionCompletedMenu.SetActive(true);
        Time.timeScale = 0f;
        isOver = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
