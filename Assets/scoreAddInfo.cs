using UnityEngine;
using TMPro;

public class scoreAddInfo : MonoBehaviour
{
    public TextMeshPro txt;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(txt.color.a <= 0){
            Destroy(gameObject, 0f);
        }
        else{
            txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, txt.color.a - 0.02f);
        }
        gameObject.GetComponent<Transform>().position = new Vector3(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y + 0.02f, 0);
    }

    public void showScore(int score){
        if(score == 50){
            txt.text = "+50";
            txt.color = new Color(255, 216, 0, 1);
        }
        else if(score == 25){
            txt.text = "+25";
            txt.color = new Color(255, 0, 0, 1);
        }
        else if(score == 20){
            txt.text = "+20";
            txt.color = new Color(0, 148, 255, 1);
        }
        else if(score == 10){
            txt.text = "+10";
            txt.color = new Color(0, 0, 0, 1);
        }
        else{
            txt.text = "+5";
            txt.color = new Color(255, 255, 255, 1);
        }
        Debug.Log("DONE");
    }

}
