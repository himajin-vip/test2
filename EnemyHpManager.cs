﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpManager : MonoBehaviour
{
  public int EnemyMaxHp = 10;
  public int EnemyCurrentHp;
  public bool Deth = false;
  public GameObject DamageText;
    // Start is called before the first frame update
    void Start()
    {
        EnemyCurrentHp = EnemyMaxHp;
    }

    // Update is called once per frame
    void Update()
    {
      if(EnemyCurrentHp<=0){
        Deth = true;
        StartCoroutine(DestroyEnemy());
      }

    }
    public void DamageHP(int damage){
      EnemyCurrentHp -= damage;
      Transform mytransform = this.transform;
      Vector3 mypos = mytransform.position;
      string str = damage.ToString();
      GameObject obj = Instantiate(DamageText, new Vector3(mypos.x,mypos.y,0), transform.rotation);
      obj.GetComponent<TextMesh>().text = str;
      obj.GetComponent<TextMesh>().color = new Color(255,255,255);
    }

    private IEnumerator DestroyEnemy(){
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);//hpが０になったら死ぬ
    }
}
