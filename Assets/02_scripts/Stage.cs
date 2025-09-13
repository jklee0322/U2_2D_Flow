using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour
{
    GameObject Origin = null;
    PlayerMove PlayBall = null;
    Goal goalObj = null;
    // Start is called before the first frame update
    void Start()
    {
        Origin = Resources.Load("Prefabs/Chicken") as GameObject;
        Debug.Log(Origin);
        if(Origin==null)
        {
            Debug.Log("리소스폴더를 확인하세요");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReCreate();
        }
    }
    void ReCreate()
    {
        if(PlayBall != null)
        {
            Destroy(PlayBall.gameObject);
        }
        /*GameObject temp = Instantiate(Origin, this.transform);
        temp.transform.position = new Vector2(0, -4);
        PlayBall = temp.GetComponent<PlayerMove>();
        */
        if(SceneManager.GetActiveScene().name=="Stage1")
        {
            GameObject temp = Instantiate(Origin, this.transform);
            temp.transform.position = new Vector2(0, -4);
            GameManager.instance.count = 2;
            Debug.Log("Stage1 목숨: " + GameManager.instance.count);
            PlayBall = temp.GetComponent<PlayerMove>();

        }
        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            GameObject temp = Instantiate(Origin, this.transform);
            temp.transform.position = new Vector2(0, -4);
            GameManager.instance.count = 3;
            Debug.Log("Stage2 목숨: " + GameManager.instance.count);
            PlayBall = temp.GetComponent<PlayerMove>();
        }
        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            GameObject temp = Instantiate(Origin, this.transform);
            temp.transform.position = new Vector2(0, -4);
            GameManager.instance.count = 5;
            Debug.Log("Stage2 목숨: " + GameManager.instance.count);
            PlayBall = temp.GetComponent<PlayerMove>();

        }
    }
    public void IsGameOver(bool isSucess = false)
    {
        if(isSucess==true)
        {
            Debug.Log("성공!~!");
            string currentSceneName = SceneManager.GetActiveScene().name;
            if(currentSceneName == "Stage1")
            {
                SceneManager.LoadScene("Stage2");
            }
            if(currentSceneName == "Stage2")
            {
                SceneManager.LoadScene("Stage3");
            }
        }
        else
        {
            Destroy(PlayBall.gameObject);
            Debug.Log("Fail");
        }
    }
}
