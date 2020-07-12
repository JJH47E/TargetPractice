using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public int max;
    private float current;
    public TextMeshProUGUI timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        current = (float) max;
    }

    // Update is called once per frame
    void Update()
    {

        if(current <= 0){
            PlayerPrefs.SetInt("current", GameObject.Find("Score").GetComponent<scoreTracker>().getScore());
            Debug.Log("set score: " + GameObject.Find("Score").GetComponent<scoreTracker>().getScore());
            if(GameObject.Find("Score").GetComponent<scoreTracker>().getScore() > PlayerPrefs.GetInt("hi")){
                PlayerPrefs.SetInt("hi", GameObject.Find("Score").GetComponent<scoreTracker>().getScore());
            }
            GameObject.Find("SceneHandler").GetComponent<sceneToGame>().endGame();
        }
        timeLeft.text = ((int) current).ToString();
        current -= Time.deltaTime;
    }
}
