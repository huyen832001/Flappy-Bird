using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    //pipeprefab mẫu ống
    public GameObject pipePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}
    //bộ đếm countdown
    private float countdown;
    //timeDuration khoảng thời gian đến trễ
    public float timeDuration;
    public bool enableGenratePipe;// cho phép sinh ra ống
    //Awake hàm dùng 1 lần 
    private void Awake()
    {
        countdown = 1f;
        enableGenratePipe = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (enableGenratePipe == true)
        {
            countdown -= Time.deltaTime;//mỗi frame countdown -=1/fps
                                        //30fps mỗi frame countdownt giảm đi 1/30s một giây (30frmaes) thì countdown giảm đi đúng 1
            if (countdown <= 0)
            {
                //sinh ra ống
                //Debug.Log("Sinh ra 1 ong!");
                Instantiate(pipePrefab, new Vector3(10, Random.Range(-1.2f, 2.1f), 0), Quaternion.identity);
                countdown = timeDuration;
            }

        }

    }
}


