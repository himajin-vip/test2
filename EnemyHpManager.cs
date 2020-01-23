using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpManager : MonoBehaviour
{
  public int EnemyMaxHp = 10;
  public int EnemyCurrentHp;
  public bool Deth = false;
  [SerializeField]
  DamageTextManager damagetextmanager;
  EnemyManager EnemyManager;
    // Start is called before the first frame update
    void Start()
    {
      damagetextmanager = GameObject.Find("GameManager").gameObject.GetComponent<DamageTextManager>();
      EnemyManager = GameObject.Find("GameManager").gameObject.GetComponent<EnemyManager>();
      EnemyCurrentHp = EnemyMaxHp;
    }

    // Update is called once per frame
    void Update()
    {
      if(EnemyCurrentHp<=0&&!Deth){
        Deth = true;
        EnemyManager.EnemyCurrentCount--;
        StartCoroutine(DestroyEnemy());
      }

    }
    public void DamageHP(int damage){
      EnemyCurrentHp -= damage;
      float x = this.transform.position.x;
      float y = this.transform.position.y;
      damagetextmanager.Make(damage,x,y, new Color(255,255,255),this.transform);
    }

    private IEnumerator DestroyEnemy(){
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);//hpが０になったら死ぬ
    }
}
