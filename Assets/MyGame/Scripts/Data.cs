using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data")]
public class Data : ScriptableObject
{
    public string playerName;
    public int attempts;
    public int correctAnswers;
    public List<int> sums = new List<int>();
}
