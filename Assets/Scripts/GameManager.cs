using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEingine.UI;
using UnityEngine.SceneManagemant;


public class GameOver : MonoBehaviour
{
    public bool GameIsOver;

    public void GameOver()
    {
        GameIsOver = true;
        Debug.Log("GAME OVER");
         
    }

}
