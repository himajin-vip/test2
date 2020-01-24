using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpManager : MonoBehaviour
{
  public int EnemyMaxHp = 10;
  public int EnemyCurrentHp;
  public bool Deth = false;
    // Start is called before the first frame update
    void Start()
    {
      EnemyCurrentHp = EnemyMaxHp;
    }

    // Update is called once per frame
    void Update()
    {
      if(EnemyCurrentHp<=0&&!Deth){
        Deth = true;
        ////////////アイテムドロップ//////////
        int i ;
        i = Random.Range(0,3);
        if(i == 2){
          ItemManager.DropItem(0,this.transform.position.x,this.transform.position.y);
        }
        ////////////////////////////////////
        EnemyManager.DethEnemy();
        StartCoroutine(DestroyEnemy());
      }

    }
    public void DamageHP(int damage){
      EnemyCurrentHp -= damage;
      float x = this.transform.position.x;
      float y = this.transform.position.y;
      DamageTextManager.Make(damage,x,y, new Color(255,255,255),this.transform);
    }

    private IEnumerator DestroyEnemy(){
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);//hpが０になったら死ぬ
    }
}
