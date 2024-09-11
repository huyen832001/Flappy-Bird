using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    // Start is called before the first frame update
    //OnTriggerEnter2D 1 doi tuong bat dau or ket thuc va cham
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //FindObjectOfType tim
        SoundController.instance.PlayThisSound("point", 0.5f);

        FindObjectOfType<Score>().addScore();
        
    }
}
