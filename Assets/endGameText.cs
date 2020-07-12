using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endGameText : MonoBehaviour
{
    private TextMeshProUGUI txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<TextMeshProUGUI>();
        txt.color = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(txt.color.a < 1f){
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, txt.color.a + 0.02f);
        }
    }
}
