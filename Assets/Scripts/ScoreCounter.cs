using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text Score;
    private int Counter;
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Counter = 36 - GameObject.FindGameObjectsWithTag("Brick").Length;
        Score.text = "SCORE: " + Counter + "/36";

        if (Counter == 37) 
        {
            FindObjectOfType<GameManager>().winning();
            Destroy(Ball);
        }
    }
}
