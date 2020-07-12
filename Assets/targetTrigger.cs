using UnityEngine;
using TMPro;

public class targetTrigger : MonoBehaviour
{

    public GameObject scoreSum;
    //public scoreTracker track;
    private int toAdd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            //Debug.Log("Trigger!");
            //look at position of target --
            //find where projectile was placed (symetrical therefore we only need to look at x or y coordinate, both individually --
            //calculate where on target projectile landed --
            //add score to counter
            //maybe despawn projectile
            //despawn target!
            Vector3 projectile = this.gameObject.GetComponent<Transform>().position;
            Vector3 targetBoard = col.gameObject.GetComponent<Transform>().position;
            float x_diff = projectile.x - targetBoard.x;
            float y_diff = projectile.y - targetBoard.y;
            //Debug.Log("x-diff: " + x_diff + " y-diff: " + y_diff);
            GameObject textTemp = (GameObject) Instantiate(scoreSum, new Vector3(targetBoard.x, targetBoard.y + 0.4f, 0), Quaternion.Euler(0, 0, 0));
            textTemp.transform.SetParent(GameObject.Find("Canvas").transform);
            if((Mathf.Abs(x_diff) < 8f/48f) && (Mathf.Abs(y_diff) < 8f/48f)){
                Debug.Log("Yellow");
                //Debug.Log(textTemp.name);
                toAdd = 50;
                textTemp.GetComponent<scoreAddInfo>().showScore(50);
            }
            else if((Mathf.Abs(x_diff) < 15f/48f) && (Mathf.Abs(y_diff) < 15f/48f)){
                Debug.Log("Red");
                toAdd = 25;
                textTemp.GetComponent<scoreAddInfo>().showScore(25);
            }
            else if((Mathf.Abs(x_diff) < 19f/48f) && (Mathf.Abs(y_diff) < 19f/48f)){
                Debug.Log("Blue");
                toAdd = 20;
                textTemp.GetComponent<scoreAddInfo>().showScore(20);
            }
            else if((Mathf.Abs(x_diff) < 27f/48f) && (Mathf.Abs(y_diff) < 27f/48f)){
                Debug.Log("Black");
                toAdd = 10;
                textTemp.GetComponent<scoreAddInfo>().showScore(10);
            }
            else{
                Debug.Log("White");
                toAdd = 5;
                textTemp.GetComponent<scoreAddInfo>().showScore(5);
            }
            //Add Score to total
            GameObject.Find("Score").GetComponent<scoreTracker>().addScore(toAdd);
            Destroy(col.GetComponent<BoxCollider2D>());
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            col.gameObject.GetComponent<Animator>().SetBool("despawn", true);
            Destroy(this.gameObject);
        }
    }
}
