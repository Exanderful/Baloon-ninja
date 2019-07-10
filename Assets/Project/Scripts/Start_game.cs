using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_game : MonoBehaviour {

    public GameObject Top_elements;
    public GameObject Difficulty_text;
    public GameObject Title_text;
    public GameObject Timer;

	void Start () {
        GetComponent<Button>().onClick.AddListener(OnClick);
	}
	
	void OnClick () {
        LeanTween.scale(gameObject, new Vector3(0f, 0f, 0f), 0.3f).setEaseInElastic();
        LeanTween.scale(Difficulty_text.gameObject, new Vector3(0f, 0f, 0f), 0.3f).setEaseInElastic();
        LeanTween.scale(Title_text.gameObject, new Vector3(0f, 0f, 0f), 0.3f).setEaseInElastic();
        Top_elements.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        Timer.GetComponent<Timer>().StartTimer();
    }
}
