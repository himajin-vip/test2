
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Weapon : MonoBehaviour
{
    private List<Enemy> hitList = new List<Enemy>();
    public void Hit(Enemy enemy){
        new HitEnemyCheck(hitList,enemy);
    }
    public void OnEnd(){
        GameManager.SetState(States.EnemyDamage,new HitListData(hitList));
        Destroy (this.gameObject);
    }
}