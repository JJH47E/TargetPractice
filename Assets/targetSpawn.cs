using System.Collections;
using UnityEngine;

public class targetSpawn : MonoBehaviour
{
    public Object target;
    private float despawnTime, spawnTime;
    public int max;
    public int count = 0;
    private bool init = false, play = true;

    void Start()
    {
        StartCoroutine(startGame());
    }

    void Update()
    {
        // if((count < max) && (init == true)){
        //     StartCoroutine(spawnTarget());
        // }
    }

    IEnumerator spawnTarget(){
        double x_spawn = Random.Range(-800f, 800f) / 100;
        double y_spawn = Random.Range(-400f, 300f) / 100;
        GameObject despawn = (GameObject) Instantiate(target, new Vector3((float) x_spawn, (float) y_spawn, 0f), Quaternion.Euler(0, 0, 0));
        count = count + 1;
        //Debug.Log("Object instatntiated at " + x_spawn + " on the x; and " + y_spawn + " on the y" + "0 on the z");
        despawnTime = Random.Range(1.5f, 3f);
        //wait despawnTime seconds
        yield return new WaitForSeconds(despawnTime);
        despawn.GetComponent<Animator>().SetBool("despawn", true);
        //Debug.Log("Target Despawning");
    }

    IEnumerator startGame(){
        //wait n seconds
        //spawn
        //repeat
        while(play == true){
            float rng = Random.Range(0.2f, 0.7f);
            yield return new WaitForSeconds(rng);
            StartCoroutine(spawnTarget());
        }
        init = true;
    }
}
