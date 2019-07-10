using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score = 0;

    void Start()
    {
        GetComponent<Text>().text = "" + score;
    }

    public void Show_score(int increment_value)
    {
        score += increment_value;
        GetComponent<Text>().text = "" + score;
    }
}
