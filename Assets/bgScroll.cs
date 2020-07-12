using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScroll : MonoBehaviour
{
    public float time = 0.5f, multi = 1f;
    public Transform cloud;
    private bool shift = false, playing = true, canShift = true;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = cloud.position;
        StartCoroutine(shiftCloud());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(shift == true && canShift == true){
            canShift = false;
            cloud.position = new Vector3(pos.x + (multi * (19f/48f)), pos.y, pos.z);
            Debug.Log("shifted");
        }   
        else if(canShift == true){
            canShift = false;
            cloud.position = pos;
            Debug.Log("shifting");
        }
    }

    public IEnumerator shiftCloud(){
        while(playing == true){
            yield return new WaitForSeconds(1/time);
            shift = !shift;
            canShift = true;
        }
    }
}
