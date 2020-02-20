using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeEfectObj : MonoBehaviour
{
    Timer timer;
    Timer timer2;
    Value ChargeSpeed = new IntValue(3);
    public void Set()
    {
        timer =  new Timer(ChargeSpeed.GetIntValue()/2);
        timer2 = new Timer(ChargeSpeed.GetIntValue());
    }
    public void Count(){
        if(!timer.CountUp()){
            this.gameObject.SetActive(true);
        }
        if(!timer2.CountUp()){
            this.GetComponent<Animator>().SetFloat("Speed",2f);
        }
    }
    public void SetSpeed(Value speed){
        ChargeSpeed = speed;
    }
}
