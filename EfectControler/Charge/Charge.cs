using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge:IEfect
{
    GameObject Chargeobj;
    ChargeEfectObj chargeEfectObj;
    public Charge(GameObject player){
        Chargeobj = player.transform.Find("tameefect").gameObject;
        chargeEfectObj = Chargeobj.GetComponent<ChargeEfectObj>();
    }

    public void On(){
        chargeEfectObj.Set();
    }
    public void Count(){
        chargeEfectObj.Count();
    }
    public void End(){
        Chargeobj.SetActive(false);
    }
    public void SetChargeSpeed(Value value){
        chargeEfectObj.SetSpeed(value);
    }
}