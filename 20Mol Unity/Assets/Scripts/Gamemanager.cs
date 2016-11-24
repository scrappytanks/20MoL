using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Text MessageText;

    public GameObject[] Player;

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

        for (int i = 0; i < Player.Length; i++)
        {
            Player[i].SetActive(false);
        }

        MessageText.text = "Get Ready";

    }
    void Update()
    {
        switch (m_GameState)
        {
            case GameState.Start:
                if (Input.GetKeyUp(KeyCode.Return) == true)
                {

                    MessageText.text = "";





                    m_GameState = GameState.Playing;



                    for (int i = 0; i < Player.Length; i++)
                    {
                        Player[i].SetActive(true);
                    } 
                }

                break;
            case GameState.Playing:
                bool isGameOver = false;







                if (OnePlayerLeft() == true)
                {
                    isGameOver = true;
                }
                else if (IsPlayerDead() == true)
                {
                    isGameOver = true;
                }



                if (isGameOver == true)
                {
                    m_GameState = GameState.GameOver;

                    if (IsPlayerDead() == true)
                    {
                        MessageText.text = "TRY AGIN";
                    }
                    else
                    {
                        MessageText.text = "WINNER!";
                    }


                }
                break;

            case GameState.GameOver:
                if(Input.GetKeyUp(KeyCode.Return)  == true)
                {
                    m_GameState = GameState.Playing;

                    MessageText.text = "";

                    for (int i = 0; i < Player.Length; i++)
                    {
                        Player[i].SetActive(true);

                    }


                }
                break;


        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }


    }

    private bool OnePlayerLeft()
    {
        int numPlayersLeft = -0;


        for (int i = 0; i < Player.Length; i++)
        {
            if (Player[i].activeSelf == true)
        {
                numPlayersLeft++;

        }
        }


        return numPlayersLeft <= 1;

    }

    private bool IsPlayerDead()
    {
        for (int i = 0; i < Player.Length; i++)
        {
            if (Player[i].activeSelf == false)
            {
                if (Player[i].tag == "Player")
                    return true;
            }
        }
        return false;
    }




}