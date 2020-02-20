using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLibrary
{
  private static Dictionary<Enemys,GameObject> EnemyList = new Dictionary<Enemys ,GameObject>();

  public void SetUp(){
    EnemyList.Add(Enemys.slime,(GameObject)Resources.Load("prefab/Enemy/Slime"));
    EnemyList.Add(Enemys.Redslime,(GameObject)Resources.Load("prefab/Enemy/RedSlime"));
    EnemyList.Add(Enemys.Bigslime,(GameObject)Resources.Load("prefab/Enemy/BigSlime"));
    EnemyList.Add(Enemys.Kingslime,(GameObject)Resources.Load("prefab/Enemy/KingSlime"));

  }
  public GameObject MakeEnemy(Enemys enemy){
    return GameManager.Instantiate(EnemyList[enemy],new Vector3(0,0,0),Quaternion.identity);
  }



}
