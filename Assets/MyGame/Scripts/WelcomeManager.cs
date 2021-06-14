using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WelcomeManager : MonoBehaviour
{
    public InputField nameInput;
    public Data data;
    
    public void StartGame()
    {
        if(nameInput.text == null || nameInput.text == "")
        {
            return;
        }

        data.maxSum = 10;
        int sum = Random.Range(2, data.maxSum);
        data.summandOne = Random.Range(1, sum);
        data.summandTwo = sum - data.summandOne;

        SceneManager.LoadScene(1);
    }
}
