using System.Collections;
using UnityEngine;

public class clickShoot : MonoBehaviour
{
    private bool isPressed;
    public Object projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate(){
        if(isPressed == true){
            isPressed = false;
            //Debug.Log("pew");
            StartCoroutine(clicked());
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            isPressed = true;
        }
    }

    IEnumerator clicked(){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        Object toDespawn = Instantiate(projectile, mousePos, Quaternion.Euler(0, 0, 0));
        //Debug.Log("Projectile deployed at: " + mousePos.x + " " + mousePos.y + " " + mousePos.z);
        yield return new WaitForSeconds(1f);
        Destroy(toDespawn, 0f);
        //Debug.Log("finished coroutine");
    }
}
