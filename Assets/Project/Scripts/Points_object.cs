using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points_object : MonoBehaviour {

    void Start()
    {
        transform.parent = GameObject.Find("Game_elements").transform;
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 0.1f).setEaseInBounce();
        Destroy(gameObject, 0.5f);
    }
}
