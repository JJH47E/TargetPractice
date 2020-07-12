using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class listScore : MonoBehaviour
{
    public TextMeshProUGUI txt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        txt.text = "Score: " + PlayerPrefs.GetInt("current").ToString();
    }
}
