using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo_object : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.parent = GameObject.Find("Game_elements").transform;
        transform.localRotation = Quaternion.Euler(0f, 0f, Random.Range(-20f, 20f));
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 0.1f).setEaseInBounce();
        Destroy(gameObject, 1f);
	}
}
