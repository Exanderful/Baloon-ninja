using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaloonSwipe : MonoBehaviour {

    public GameObject Points_text;

    private void Start()
    {
        gameObject.transform.parent = GameObject.Find("Game_elements").transform;
        GetComponent<Rigidbody2D>().gravityScale = GetComponent<Rigidbody2D>().gravityScale * Change_difficulty.difficulty;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Swipe")
        {
            GameObject Score_text = GameObject.Find("Score_text");
            GameObject PointObj = Instantiate(Points_text);
            PointObj.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 0f);
            if (gameObject.name == "Baloon_1(Clone)")
            {
                Score_text.GetComponent<Score>().Show_score(1);
                PointObj.GetComponent<Text>().text = "+1";
            }
            if (gameObject.name == "Baloon_2(Clone)")
            {
                Score_text.GetComponent<Score>().Show_score(2);
                PointObj.GetComponent<Text>().text = "+2";
            }
            if (gameObject.name == "Baloon_3(Clone)")
            {
                Score_text.GetComponent<Score>().Show_score(3);
                PointObj.GetComponent<Text>().text = "+3";
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Barrier")
        {
            Destroy(gameObject);
        }
    }
}
