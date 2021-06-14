using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data")]
public class Data : ScriptableObject
{
    public string playerName;
    public int maxSum;
    public int summandOne;
    public int summandTwo;
    public int attempts;
}
