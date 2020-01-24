﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTextManager : MonoBehaviour
{
    public static void Make(int damage ,float x,float y,Color color,Transform transform){
      GameObject DamageText = (GameObject)Resources.Load ("prefab/DamageText");
      GameObject obj = Instantiate(DamageText, new Vector3(x,y,0), transform.rotation);
      string str = damage.ToString();
      obj.GetComponent<TextMesh>().text = str;
      obj.GetComponent<TextMesh>().color = color;
      obj.GetComponent<DamageText>().go();
    }
}
