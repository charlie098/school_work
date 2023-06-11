using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public float LimitTime;
    public Text text_Timer;
    public Text text_GameOver;

    // Start is called before the first frame update
    void Start()
    {
        LimitTime = 12.0f;
        text_GameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LimitTime -= Time.deltaTime;
        text_Timer.text = "지각까지 :" + Mathf.Round(LimitTime);

        GameOver();

    }

    void GameOver()
    {
        if (LimitTime <= 0)
        {
            text_GameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(2);
            Time.timeScale = 1;
        }
    }

}
