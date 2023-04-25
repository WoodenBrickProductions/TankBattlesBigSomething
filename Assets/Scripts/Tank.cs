using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && transform.position.x <= 0)
	        transform.position -= transform.right * 2;

        if(Input.GetKeyDown(KeyCode.D) && transform.position.x >= 0)
	        transform.position += transform.right * 2;
    }

    public void OnHit()
    {

    }
}
