using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP_Manager : MonoBehaviour
{
  public int PlayerMaxHP;
  public int PlayerCurrentHP;
  public GameObject DamageText;
    // Start is called before the first frame update
    void Start()
    {
      SetMaxHP();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DamageHP(int damage){
      PlayerCurrentHP -= damage;
      Transform mytransform = this.transform;
      Vector3 mypos = mytransform.position;
      string str = damage.ToString();
      GameObject obj = Instantiate(DamageText, new Vector3(mypos.x,mypos.y,0), transform.rotation);
      obj.GetComponent<TextMesh>().color = new Color(255,0,0);
      obj.GetComponent<TextMesh>().text = str;
    }
    public void SetMaxHP(){
      PlayerCurrentHP = PlayerMaxHP;
    }
}
