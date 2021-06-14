using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Image backroundImage;
    public InputField summandOneField;
    public InputField summandTwoField;
    public Text attemptsText;
    public Text nameText;
    public Text sumText;

    public Color startColor;
    public Color trueColor;
    public Color falseColor;

    private int sum;
    private bool correct = false;

    private void Start()
    {
        sum = WelcomeManager.currentData.sums[Random.Range(0, WelcomeManager.currentData.sums.Count)];
        WelcomeManager.currentData.sums.Remove(sum);
        backroundImage.color = startColor;

        attemptsText.text = WelcomeManager.currentData.attempts.ToString();
        sumText.text = sum.ToString();
        nameText.text = WelcomeManager.currentData.name;
    }

    public void CheckAnswer()
    {
        if(summandOneField.text == "" || summandTwoField.text == "")
        {
            return;
        }

        if (int.Parse(summandOneField.text) + int.Parse(summandTwoField.text)  != sum)
        {
            backroundImage.color = falseColor;
            return;
        }

        correct = true;
        backroundImage.color = trueColor;
    }

    public void NextExercice()
    {
        if (correct)
        {
            WelcomeManager.currentData.correctAnswers += 1;
            WelcomeManager.currentData.attempts -= 1;

            if (WelcomeManager.currentData.attempts == 0)
            {
                SceneManager.LoadScene(2);
                return;
            }

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
