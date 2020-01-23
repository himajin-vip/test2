using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTextManager : MonoBehaviour
{
  public GameObject DamageText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Make(int damage ,float x,float y,Color color,Transform transform){
      string str = damage.ToString();
      GameObject obj = Instantiate(DamageText, new Vector3(x,y,0), transform.rotation);
      obj.GetComponent<TextMesh>().text = str;
      obj.GetComponent<TextMesh>().color = color;
    }
}
