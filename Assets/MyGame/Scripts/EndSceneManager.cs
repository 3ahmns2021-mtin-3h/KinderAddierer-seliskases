using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public Text nameText;
    public Text correctAnswerText;

    private void Start()
    {
        nameText.text = WelcomeManager.currentData.name.ToString();
        correctAnswerText.text = WelcomeManager.currentData.correctAnswers.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
