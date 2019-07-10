using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo_checker : MonoBehaviour
{

    public GameObject Combo_text;
    int baloon_combo = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Baloon")
        {
            baloon_combo++;
        }
    }

    private void OnDestroy()
    {
        if(baloon_combo > 1)
        {
            GameObject ComboObj = Instantiate(Combo_text);
            ComboObj.transform.localPosition = gameObject.transform.localPosition;
            ComboObj.GetComponent<Text>().text = "COMBOx" + baloon_combo;
        }
    }
}
