using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public Text countText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //countText.text = "남은 횟수 : " + PlayerMove.count.ToString();
        countText.text = "남은 횟수 : " + GameManager.instance.count.ToString();
    }
}
