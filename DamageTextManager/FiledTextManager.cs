using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FiledTextManager
{
    public static void Make(string text ,float x,float y,Color color,Transform transform){
      GameObject DamageText = (GameObject)Resources.Load ("prefab/DamageText");
      GameObject obj = GameManager.Instantiate(DamageText, new Vector3(x,y,0), transform.rotation);
      string str = text;
      obj.GetComponent<TextMesh>().text = str;
      obj.GetComponent<TextMesh>().color = color;
      obj.GetComponent<FiledText>().go();
    }
}
