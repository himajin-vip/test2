using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EfectControler
{
    Dictionary<Efects,IEfect> EfectList = new Dictionary<Efects, IEfect>();
    List<IEfect> OnEfects = new List<IEfect>();
    public EfectControler(GameObject charactorobj){
        EfectList.Add(Efects.tame,new Charge(charactorobj));
    }

    public void On(Efects efects){
        if(!OnEfects.Contains(EfectList[efects])){
            OnEfects.Add(EfectList[efects]);
            EfectList[efects].On();
        }
    }
    public void Count(){
        foreach(IEfect efect in OnEfects){
            efect.Count();
        }
    }
    public void End(Efects efects){
        EfectList[efects].End();
        OnEfects.Remove(EfectList[efects]);
    }
}