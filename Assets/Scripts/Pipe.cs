using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    //speed biến tốc độ
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()// goi dua tren fps: Time.deltaTime =1/FPS(FPS cao Time.deltaTime nhỏ
    {
        Move();

    }
    //ham move chứa câu lênh di chuyển trái phải cua ong
    private void Move()
    {
        //vecto3:x y z
        //Time.deltaTime giá trị nhân vào khi chuyển động vật lý của game
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

}
