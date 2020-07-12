using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class menuHiScore : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        if(!(PlayerPrefs.HasKey("hi"))){
            PlayerPrefs.SetInt("hi", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("hi") == 0){
            txt.text = "";
        }
        else{
            txt.text = "HiScore: " + PlayerPrefs.GetInt("hi").ToString();
        }
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            clicked = true;
        }
    }

    void FixedUpdate(){
        if(clicked == true){
            SceneManager.LoadScene("inGame");
        }
    }
}
