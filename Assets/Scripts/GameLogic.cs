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
        int initialGuess = Random.Range(min, max);
        guessText.text = initialGuess.ToString();
        guess = initialGuess;
        max+=1;
    }

    public void guessHigher() {
        min = guess;
        calcGuess();
    }

    public void guessLower() {
        max = guess;
        calcGuess();
    }


    void calcGuess() {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }

    // Update is called once per frame
    void quitGame()
    {
        Application.Quit();
    }
}
