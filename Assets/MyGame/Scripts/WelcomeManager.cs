using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WelcomeManager : MonoBehaviour
{
    public InputField nameInput;
    public Data data;
    public static Data currentData { get; private set; }
    public void StartGame()
    {
        currentData = data;

        if (nameInput.text == null || nameInput.text == "")
        {
            return;
        }

        data.name = nameInput.text;
        data.correctAnswers = 0;
        data.maxSum += 10;
        data.attempts = data.maxSum;

        data.sums = new List<int>();

        for (int i = 0; i < data.maxSum; i++)
        {
            data.sums.Add(i + 1);
        }

        SceneManager.LoadScene(1);
    }
}
