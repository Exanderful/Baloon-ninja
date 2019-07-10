using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public GameObject Top_elements;
    public GameObject Finish_window;
    public Score Score;

    public int seconds = 60;
	
	public void StartTimer () {
        StartCoroutine(TimerCount());
	}

    public void EndTimer()
    {
        Top_elements.gameObject.transform.localScale = new Vector3(0f, 0f, 0f);
        LeanTween.scale(Finish_window.gameObject, new Vector3(1f, 1f, 1f), 0.3f).setEaseInOutElastic();
        Finish_window.GetComponentInChildren<Text>().text = "Score:\n" + Score.score;
    }

    IEnumerator TimerCount()
    {
        while (seconds > 0)
        {
            yield return new WaitForSeconds(1f);
            seconds--;
            GetComponent<Text>().text = seconds + "";
            if(seconds == 0)
            {
                EndTimer();
            }
        }
    }
}
