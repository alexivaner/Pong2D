using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{
    public bool isEscapetoExit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp (KeyCode.Escape)) {
            if(isEscapetoExit){
                Application.Quit();
            }
            else{
                KembaliKeMenu();
            }
        }
    }

    public void MulaiPermainan(){
        SceneManager.LoadScene("Main");
    }

    public void KembaliKeMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void HalamanCredit(){
        SceneManager.LoadScene("Credit");
    }

    public void OpenWeb(){
        Application.OpenURL("https://www.instagram.com/ivan.hutomo/");
    }

    public void OpenHelp(){
        SceneManager.LoadScene("Help");
    }
}

