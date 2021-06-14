using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adder : MonoBehaviour
{
    public static int[] GenerateSummands(int maxSum)
    {
        int sum = Random.Range(2, maxSum);
        int summandOne = Random.Range(1, sum);
        int summandTwo = sum - summandOne;
        int[] summands = { summandOne, summandTwo };
        return summands;
    }
}
