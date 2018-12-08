using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    private static Pause instance;

    public static Pause Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Pause>();

                if (instance == null)
                {
                    GameObject go = new GameObject(typeof(Pause).ToString());
                    instance = go.AddComponent<Pause>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }

    //Changes the game state from play to pause and vice versa.

    //public void ChangePauseState()
    //{
    //    if (GameManager.Instance.GameState == GameStates.Play)
    //    {
    //        Time.timeScale = 0.0f;
    //        GameManager.Instance.GameState = GameStates.Pause;
    //    }
    //    else if (GameManager.Instance.GameState == GameStates.Pause)
    //    {
    //        Time.timeScale = 1.0f;
    //        GameManager.Instance.GameState = GameStates.Play;
    //    }
    //}
}
