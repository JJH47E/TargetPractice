using UnityEngine;
using TMPro;

public class scoreTracker : MonoBehaviour
{
    public int currentScore = 0;
    public TextMeshProUGUI field;

    // Start is called before the first frame update
    void Start()
    {
        field.color = new Color(255, 216, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        field.text = currentScore.ToString();
    }

    public void addScore(int score){
        currentScore += score;
    }

    public int getScore(){
        return currentScore;
    }
}
