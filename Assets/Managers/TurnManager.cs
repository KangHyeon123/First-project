using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour

{
    public bool Playerturn = true;
   

    private void Update()
    {

        if (Playerturn)
        {
            if (Input.GetKeyDown(KeyCode.A)) // 누르면
            {
                //랜덤 공격 코드 작성
                ETurnchange(); // e로 턴 변경
            }
        }
        else
        {
            //적 한칸씩 오는거 

            Playerturn = true;
        }
    }

    public void ETurnchange()
    {
        Playerturn = !Playerturn;
    }

   
}

       
   
    
