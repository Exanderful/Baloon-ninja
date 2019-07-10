using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_creator : MonoBehaviour {

    public GameObject Swipe;

    public float SwipeDestroyTime;

    private bool dragging = false;
    private Vector2 swipe_start;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragging = true;
            swipe_start = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0) && this.dragging)
        {
            create_swipe();
        }
    }

    private void create_swipe()
    {
        dragging = false;
        Vector2 swipe_end = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject swipe = Instantiate(Swipe, swipe_start, Quaternion.identity) as GameObject;
        swipe.GetComponent<LineRenderer>().SetPosition(0, swipe_start);
        swipe.GetComponent<LineRenderer>().SetPosition(1, swipe_end);
        Vector2[] collider_points = new Vector2[2];
        collider_points[0] = new Vector2(0.0f, 0.0f);
        collider_points[1] = swipe_end - swipe_start;
        swipe.GetComponent<EdgeCollider2D>().points = collider_points;
        swipe.GetComponent<LineRenderer>().sortingOrder = 1;
        Destroy(swipe.gameObject, SwipeDestroyTime);
    }
}
