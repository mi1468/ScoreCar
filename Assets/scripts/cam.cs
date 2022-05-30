using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
 
    public GameObject player , target;
    public float cam_speed ; 
       // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    // Lerp(khodemoon , maghsad , time.deltatime);
        // transform.position = Vector3.Lerp(transform.position, player.transform.position , Time.deltaTime * cam_speed);
        transform.position =   player.transform.position  ;
        transform.LookAt(target.transform);
    }
}
