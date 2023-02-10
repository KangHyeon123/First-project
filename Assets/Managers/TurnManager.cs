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
                Turnchange();
            }
        }
        else
        {
            //적 한칸씩 오는거 
            
        }
    }

    public void Turnchange()
    {
        Playerturn = !Playerturn;
    }
}

       
   
    
