using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject effectsound , endgame;
    public Text score  , time;
    public int scorenum = 0 , maxTimer = 120;
   
   private void OnTriggerEnter(Collider other)  {
        if(other.gameObject.tag == "gift")
        {
                  Destroy( Instantiate(effectsound ) , 3);
                  Destroy(other.gameObject);
                  scorenum++;
                    score.text = scorenum.ToString();
                    maxTimer +=3;
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
          time.text = ((int)(maxTimer - Time.time)).ToString();
        if(Time.time> maxTimer)
        {

            endgame.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
