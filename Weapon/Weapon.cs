
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Weapon : MonoBehaviour
{
    private List<Enemy> HitList;
    public void SetUp(List<Enemy> list){
        HitList = list;
    }
    public void Hit(Enemy enemy){
        new HitEnemyCheck(HitList,enemy);
    }
    public void OnEnd(){
        GameManager.SetState(States.EnemyDamage);
        Destroy (this.gameObject);
    }
}