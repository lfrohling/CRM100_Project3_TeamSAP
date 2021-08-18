using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public float countdownTimer = 10;
    public bool levelStart = false;
    public GameObject target;
    public GameObject targetAnchor;
    public GameObject levelOne;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (levelStart == true)
        {
            countdownTimer -= Time.deltaTime;
            if (countdownTimer <= 0)
            {
                levelOne.gameObject.SetActive(false);
                levelStart = false;
                countdownTimer = 180;
            }
        }
    }

    public void StartLevelSystem()
    {
        levelStart = true;
        levelOne.gameObject.SetActive(true);
        score = 0;
    }

    public void Score()
    {
        score += 1;
    }
}
