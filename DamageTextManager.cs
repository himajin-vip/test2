using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTextManager : MonoBehaviour
{
    public static void Make(int damage ,float x,float y,Color color,Transform transform){
      GameObject DamageText = (GameObject)Resources.Load ("prefab/DamageText");
      string str = damage.ToString();
      GameObject obj = Instantiate(DamageText, new Vector3(x,y,0), transform.rotation);
      obj.GetComponent<TextMesh>().text = str;
      obj.GetComponent<TextMesh>().color = color;
      obj.GetComponent<DamageText>().go();
    }
}
