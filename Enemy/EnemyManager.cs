using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyManager
{
    EnemyLibrary enemyLibrary = new EnemyLibrary();
    private List<GameObject> Enemys = new List<GameObject>();

    public void SetUp(){
        enemyLibrary.SetUp();
    }

    public void MakeEnemy(Dictionary<Enemys,Value> enemylist,MoveManager moveManager){
       foreach(Enemys enemy in enemylist.Keys){
            GetValue(enemylist,enemy,moveManager);
       }
    }
    public void GetValue(Dictionary<Enemys,Value> enemylist ,Enemys enemy,MoveManager moveManager){
        foreach(Value value in enemylist.Values){
            make(enemy,value,moveManager);
        }
    }
    private void make(Enemys enemy ,Value value,MoveManager moveManager){
        GameObject newEnemy;
        for(int i= 0;i<value.GetIntValue();i++){
            newEnemy = enemyLibrary.MakeEnemy(enemy);
            Enemys.Add(newEnemy);
            MakeMove(newEnemy,moveManager);
        }
    }
    private void MakeMove(GameObject enemy,MoveManager moveManager){
        Move move = new RandomMove(enemy.transform,enemy.GetComponent<Animator>(),new IntValue(1));
        moveManager.Add(MoveState.Main,enemy,move);
        moveManager.Add(MoveState.Atack,enemy,move);
    }
    public void MapMove(MoveManager move){
        foreach(GameObject enemy in Enemys){
            move.Remove(enemy);
            GameManager.Destroy(enemy);
        }
    }

}