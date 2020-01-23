using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_HP_Manager : MonoBehaviour
{
  public int PlayerMaxHP;
  public int PlayerCurrentHP;
  public DamageTextManager damagetextmanager;
  public EfectManager EfectManager;
    // Start is called before the first frame update
    void Start()
    {
      SetMaxHP();
    }

    // Update is called once per frame
    void Update()
    {
      if(PlayerCurrentHP<=0){
        gameover();
      }
    }
    public void DamageHP(int damage){
      PlayerCurrentHP -= damage;
      float x = this.transform.position.x;
      float y = this.transform.position.y;
      damagetextmanager.Make(damage,x,y,new Color(255,0,0),this.transform);
    }
    public void recoveryHP(int recovery){
      PlayerCurrentHP += recovery;
      if(PlayerCurrentHP>PlayerMaxHP){
        PlayerCurrentHP = PlayerMaxHP;
      }
      float x = this.transform.position.x;
      float y = this.transform.position.y;
      damagetextmanager.Make(recovery,x,y,new Color(0,255,0),this.transform);
      EfectManager.kaihukuefecton(this.transform.position.x,this.transform.position.y,this.gameObject);
    }
    public void SetMaxHP(){
      PlayerCurrentHP = PlayerMaxHP;
    }
    public void gameover(){
      SceneManager.LoadScene("end");
    }
}
