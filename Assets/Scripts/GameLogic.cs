using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] Text guessText;

    int guess = 0;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    void StartGame() {
        calcGuess();
    }

    public void guessHigher() {
        min = guess + 1;
        calcGuess();
    }

    public void guessLower() {
        max = guess - 1;
        calcGuess();
    }


    void calcGuess() {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    // Update is called once per frame
    void quitGame()
    {
        Application.Quit();
    }
}
