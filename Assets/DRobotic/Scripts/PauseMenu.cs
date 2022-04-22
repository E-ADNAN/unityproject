using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    
    public GameObject pauseMenuUI;
    public static bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.Escape)) {
             if(isPaused){
                 resumeGame();
             }else{
                 pauseGame();
             }
         }
    }

    public void exitGame(){
       Application.Quit();
    }

    public void switchToMainMenu(){
        SceneManager.LoadScene(0);
    }

    public void resumeGame() {
     pauseMenuUI.SetActive(false);
     Time.timeScale = 1f;
     isPaused = false;
    }
    private void pauseGame() {
     pauseMenuUI.SetActive(true);
     Time.timeScale = 0f;
     isPaused = true;
    }


}
