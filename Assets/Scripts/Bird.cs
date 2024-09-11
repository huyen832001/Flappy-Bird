using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    // jumpForce lực nhảy
    public float jumpForce;
    // bool trả về giá trị đúng or sai
    private bool levelStart;
    public GameObject gameController;
    public GameObject gameOverObj;
    
    private void Awake()
    //hàm đầu tiên
    {
        //this là một con trỏ trỏ tới rig
        //GetComponent<>() là để lấy component/ script
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        levelStart = false;
        rigidbody.gravityScale = 0;
        //timeScale kiem soat thoi gian toc do troi qua
        Time.timeScale = 1;


        //kiểm tra
        //if(rigibody != null)
        //{
        //    Debug.Log("Da tim thay Rigidbody2D");
        //}
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    this.gameObject.GetComponent<Rigidbody2D>();
    //}

    // Update is called once per frame
    //update chay lien tuc moi frame
    void Update()
    {
        //kiem tra xem phim space co dc bam ko
        //Getkeydown bam phim 1 lan duy nhat
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundController.instance.PlayThisSound("wing", 0.5f);

            if (levelStart == false)
            {
                levelStart = true;
                rigidbody.gravityScale = 6;
                gameController.GetComponent<PipeGenerator>().enableGenratePipe = true;
            }
            //Debug.Log("space pressed");
            BirdMoverUP();
        }

    }
    public void resetGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    //lam chim bay len 1 khoang
    private void BirdMoverUP()
    {
        //velocity vecto van toc huong mui ten
        rigidbody.velocity = Vector2.up * jumpForce;
    }
    //OnCollisionEnter2D va cham
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundController.instance.PlayThisSound("hit", 0.5f);

        //Debug.Log("Va cham!");
        GameOver();
        




    }
    
    public void GameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0;

    }
}


