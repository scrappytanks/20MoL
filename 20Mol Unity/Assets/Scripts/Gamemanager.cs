using UnityEngine;
using System.Collections;

public class Gamemanager : MonoBehaviour
{

    public enum GameState
    {
        Start,
        Playing,
        GameOver

    };

    private GameState m_GameState;
    public GameState Sate { get { return m_GameState; } }



    private void Awake()
    {
        m_GameState = GameState.Start;

    }

    private void Start()
    {
        
    }


}