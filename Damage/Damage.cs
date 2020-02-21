using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//test

public class Damage:MonoBehaviour
{
    private int Lv = 5;
    private int Str = 25;
    private int Dex = 1;
    private int buki = 25;
    private int Vit = 30;
    private int boug = 0;
    private int skill = 1;
 
  void Start(){
    float Def = Vit/2+Lv/2+boug;
    float kihon = (Str+Dex/10);
    float exDef1 = 4000+Def;
    float exDef2 = (4000+Def*10);
    float exDef = exDef1/exDef2;
    float i =((kihon+buki)*skill)*exDef;
    Debug.Log((int)i);
  }
}
