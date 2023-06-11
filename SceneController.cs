using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    /*
    public GameObject makeStart;

     //Start is called before the first frame update
    
    private void Start()
    {
        DontDestroyOnLoad(makeStart);
    }

    */


    /*
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Time.timeScale = 1;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    
    */


    public void GameTitle()
    {
        SceneManager.LoadScene(0);
    }
    public void Help()
    {
        SceneManager.LoadScene(1);
    }

    public void GameStart()
    {
        SceneManager.LoadScene(2);
    }

    public void GameSceneChange()
    {
        //OnEnable();
        SceneManager.LoadScene(3);
    }

    public void GameEnding()
    {
        SceneManager.LoadScene(4);
    }


}
