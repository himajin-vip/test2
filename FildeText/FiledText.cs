using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiledText
{
    public void Make(string text,Color color,Transform transform){
      GameObject DamageText = (GameObject)Resources.Load ("prefab/DamageText");
      GameObject obj = GameManager.Instantiate(DamageText, new Vector3(transform.position.x,transform.position.y,0), transform.rotation);
      string str = text;
      obj.GetComponent<TextMesh>().text = str;
      obj.GetComponent<TextMesh>().color = color;
      obj.GetComponent<FiledTextObj>().go();
    }
}
