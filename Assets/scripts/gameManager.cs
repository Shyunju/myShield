using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager I;
    public GameObject square;
    public Text timeTxt;
    float alive = 0f;
    public GameObject endPanel;
    public Text thisScoreTxt;
    bool isRunning = true;


    private void Awake()
    {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            alive += Time.deltaTime;
            timeTxt.text = alive.ToString("N2");
        }
        
    }

    void makeSquare()
    {
        Instantiate(square);
    }
    public void gameOver()
    {
        isRunning = false;
        Time.timeScale = 0.0f;
        thisScoreTxt.text = alive.ToString("N2");
        endPanel.SetActive(true);
    }
}

