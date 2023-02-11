using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//https://www.engedi.kr/unity/?q=YToxOntzOjEyOiJrZXl3b3JkX3R5cGUiO3M6MzoiYWxsIjt9&bmode=view&idx=3738758&t=board
public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public int hp;

    public int nowDmg;

    public int nowNum;
    public int nowScore;
    public int highestScore;
    public int nowMoney;
    
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            SceneManager.LoadScene("Result");
        } ;
    }
}
