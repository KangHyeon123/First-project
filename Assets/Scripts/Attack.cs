using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class Attack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.5f;
    public float bulletSpeed = 5f;
    public List<GameObject> enemies;//게임 오브젝트 말고 몬스터로 넣기
    private int bulletDmg;
    private int bulletNum;
    
    void Start()
    {
        bulletDmg = GameManager._instance.nowDmg;
        bulletNum = GameManager._instance.nowNum;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private List<int> enemyCheck;
    private int enemLineCheck;
    public GameObject target;
    
    void Targetting()//타겟 반환
    {
        for (int i = 48; i > 0; i--)//몇번째 줄이 맨 앞줄
        {
            if (enemies[i])
            {
                enemLineCheck = Math.Abs(((i - 1) / 6) - 7);
                break; //0이면 죽기 직전 줄
            }
            
        }
        for (int i = (enemLineCheck*7)-1; i > enemLineCheck*6; i--)//맨 앞줄 어떤 자리에 있는지
        {
            if (enemies[i])
            {
                if (i % 6 == 0)
                {
                    enemyCheck.Add(6);
                    
                }
                else
                {
                    enemyCheck.Add(i % 6);
                }
            }
        }

        int targetNum = Random.Range(1, enemyCheck.Count);
        target = enemies[enemLineCheck*6+enemyCheck[targetNum]] ;
        enemyCheck.Clear();
        enemLineCheck = 0;
    }
    
    
    void Shoot()
    {
        int diceResult=Dice();
        for(int i =0;i<diceResult;i++ ){RandomSlot();}
        Targetting();
        //한놈이 죽을때까지 때려야함
        Vector2 direction = (target.transform.position - transform.position).normalized;
        var bullet = ObjectPool.GetObject();
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = direction * bulletSpeed;
        target.hp -= bulletDmg; //닿으면 애니메이션
        if (target.hp<=0)
        {
            Kill();

        } 
        //닿으면 사라져야함
    }

    void Kill()
    {
        enemies.Remove(target);//리스트에서 삭제
        Destroy(target);
        GameManager._instance.nowMoney += 500;
        Targetting();
        
    }

    int Dice()
    {
        int diceResult= Random.Range(1, 7);
        if (diceResult ==1)
        {
            
        }
        else if (diceResult == 2)
        {
            
        }
        else if (diceResult == 3)
        {
            
        }
        else if (diceResult == 4)
        {
            
        }
        else if (diceResult == 5)
        {
            
        }
        else
        {
            
        }

        return diceResult;
    }

    void RandomSlot()
    {
        int slotResult= Random.Range(1, 7);
        if (slotResult ==1)//dmg 1
        {
            
        }
        else if (slotResult == 2)//dmg 2
        {
            
        }
        else if (slotResult == 3)//dmg3
        {
            
        }
        else if (slotResult == 4)//num1
        {
            
        }
        else if (slotResult == 5)//num2
        {
            
        }
        else //num3
        {
            
        }

    }
}
