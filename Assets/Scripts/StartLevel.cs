using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public GameObject levelStart;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            LevelSystem start = levelStart.GetComponent<LevelSystem>();
            start.StartLevelSystem();
        }
    }
}
