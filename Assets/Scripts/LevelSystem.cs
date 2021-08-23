using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    public float countdownTimer = 120f;
    private int minutesOnTimer = 2;
    private int secondsOnTimer = 0;
    public Text timerDisplay;
    
    public bool levelStart = false;
    public GameObject target;
    public GameObject targetAnchor;
    public GameObject levelOne;
    public GameObject levelTwo;
    public GameObject levelThree;
    public GameObject levelFour;
    public GameObject levelFive;
    public GameObject levelSix;
    public GameObject levelSeven;
    public GameObject levelEight;
    public GameObject levelNine;
    public GameObject levelTen;
    public GameObject levelEleven;
    public GameObject levelTwelve;
    public int levelCounter = 0;
    
    public int score = 0;
    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        //DisplayTime(countdownTimer);
        //CheckLevelSystem(countdownTimer);
        if (levelStart == true)
        {
            countdownTimer -= Time.deltaTime;
            if (countdownTimer <= 0)
            {
                levelTwelve.gameObject.SetActive(false);
                levelStart = false;
                countdownTimer = 180;
                levelCounter = 0;
            }
            if (countdownTimer <= 10f && levelCounter == 11)
            {
                levelEleven.gameObject.SetActive(false);
                levelTwelve.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 20f && levelCounter == 10)
            {
                levelTen.gameObject.SetActive(false);
                levelEleven.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 30f && levelCounter == 9)
            {
                levelNine.gameObject.SetActive(false);
                levelTen.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 40f && levelCounter == 8)
            {
                levelEight.gameObject.SetActive(false);
                levelNine.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 50f && levelCounter == 7)
            {
                levelSeven.gameObject.SetActive(false);
                levelEight.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 60f && levelCounter == 6)
            {
                levelSix.gameObject.SetActive(false);
                levelSeven.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 70f && levelCounter == 5)
            {
                levelFive.gameObject.SetActive(false);
                levelSix.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 80f && levelCounter == 4)
            {
                levelFour.gameObject.SetActive(false);
                levelFive.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 90f && levelCounter == 3)
            {
                levelThree.gameObject.SetActive(false);
                levelFour.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 100f && levelCounter == 2)
            {
                levelTwo.gameObject.SetActive(false);
                levelThree.gameObject.SetActive(true);
                levelCounter += 1;
            }
            if (countdownTimer <= 110f && levelCounter == 1)
            {
                levelOne.gameObject.SetActive(false);
                levelTwo.gameObject.SetActive(true);
                levelCounter += 1;
            }
        }
        if (timerDisplay != null)
        {
            if (countdownTimer >= 60f)
            {
                minutesOnTimer = (int)Mathf.Floor(countdownTimer) / 60;
                secondsOnTimer = (int)countdownTimer - (minutesOnTimer * 60);
            }
            else
            {
                minutesOnTimer = 0;
                secondsOnTimer = (int)countdownTimer;
            }

            if (secondsOnTimer >= 10)
            {
                timerDisplay.text = minutesOnTimer + ":" + secondsOnTimer;
            }
            else if (secondsOnTimer < 10)
            {
                timerDisplay.text = minutesOnTimer + ":0" + secondsOnTimer;
            }
        }
    }

    public void StartLevelSystem()
    {
        levelStart = true;
        levelOne.gameObject.SetActive(true);
        score = 0;
        scoreDisplay.text = "Score: " + score;
        levelCounter = 1;
    }

    //public void CheckLevelSystem(float countdownTimer)

    //void DisplayTime(float countdownTimer)

    public void Score()
    {
        score += 1;
        scoreDisplay.text = "Score: " + score;
    }
}
