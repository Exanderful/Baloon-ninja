using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bomb_swipe : MonoBehaviour {

    private void Start()
    {
        gameObject.transform.parent = GameObject.Find("Game_elements").transform;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Swipe")
        {
            GameObject Timer_text = GameObject.Find("Timer_text");
            int timer_seconds = Timer_text.GetComponent<Timer>().seconds -= 10;
            Timer_text.GetComponent<Text>().text = timer_seconds + "";
            if(timer_seconds <= 0)
            {
                Timer_text.GetComponent<Timer>().seconds = 0;
                Timer_text.GetComponent<Timer>().EndTimer();
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Barrier")
        {
            Destroy(gameObject);
        }
    }
}
