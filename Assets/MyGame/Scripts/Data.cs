using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data")]
public class Data : ScriptableObject
{
    [HideInInspector]
    public string playerName;
    [HideInInspector]
    public int attempts;
    [HideInInspector]
    public int correctAnswers;
    [HideInInspector]
    public int maxSum;
    [HideInInspector]
    public List<int> sums = new List<int>();
}
