using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("BGM");
        if(obj.Length > 1){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        gameObject.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
