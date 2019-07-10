using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_difficulty : MonoBehaviour {

    public static int difficulty = 1;

	void Start () {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (difficulty == 3)
        {
            difficulty = 1;
        }
        else
        {
            difficulty++;
        }
        switch (difficulty)
        {
            case 1:
                GetComponent<Text>().text = "Difficulty:" + "\nEasy";
                break;
            case 2:
                GetComponent<Text>().text = "Difficulty:" + "\nNormal";
                break;
            case 3:
                GetComponent<Text>().text = "Difficulty:" + "\nHard";
                break;
        }
    }
}
