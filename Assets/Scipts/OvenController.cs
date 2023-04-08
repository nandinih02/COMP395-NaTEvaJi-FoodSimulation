using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenController : MonoBehaviour
{

    private bool scoreUp = false, scoreDown = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pan"))
        {
            print("Pan in the oven");
            int tempAmount = this.gameObject.GetComponent<Temperature>().tempAmount;
            if (tempAmount == 350 && !scoreUp)
            {
                ScoreStatic.score += 50;
                scoreUp = true;
            }
            else if(tempAmount >= 400 && !scoreDown)
            { 
                ScoreStatic.score -= 100;
                scoreDown = true;
            }
            
        }


        if (collision.gameObject.CompareTag("Bowl"))
        {
            print("Cautions!!! Bowl in the oven");
            int tempAmount = this.gameObject.GetComponent<Temperature>().tempAmount;
            if (tempAmount >0)
            {
                ScoreStatic.score -= 200;
            }

        }

    }      
}
