using UnityEngine;

public class targetAnimation : MonoBehaviour
{
    private targetSpawn spawnHandler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void despawnObject(){
        spawnHandler = GameObject.Find("SpawnHandler").GetComponent<targetSpawn>();
        spawnHandler.count = spawnHandler.count - 1;
        Destroy(this.gameObject);
    }
}
