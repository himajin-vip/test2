using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyManager
{
    EnemyLibrary enemyLibrary = new EnemyLibrary();
    private List<Charactor> Enemys = new List<Charactor>();


    public void SetUp(){
        enemyLibrary.SetUp();
    }


    public void MapMove(MoveManager move){
        foreach(Enemy enemy in Enemys){
            move.Remove(enemy.GetObj());
            GameManager.Destroy(enemy.GetObj());
        }
        Enemys.Clear();
    }
    public void MakeEnemy(Dictionary<Enemys,Value> enemylist,MoveManager moveManager){
       foreach(KeyValuePair<Enemys,Value> enems in enemylist){
           make(enems,moveManager);
       }
    }
    private void make(KeyValuePair<Enemys,Value> enems,MoveManager moveManager){
        GameObject newEnemy;
        for(int i= 0;i<enems.Value.GetIntValue();i++){
            newEnemy = enemyLibrary.MakeEnemy(enems.Key);
            Charactor Enemy = newEnemy.GetComponent<Enemy>();
            Enemy.LoadStatus(Statuss.Name,new StringValue(enems.Key.ToString()));
            new CSVLoader().EnemyLoad(Enemy);
            Enemys.Add(Enemy);
            MakeMove(newEnemy,moveManager);
        }
    }
    private void MakeMove(GameObject enemy,MoveManager moveManager){
        Move move = new RandomMove(enemy.transform,enemy.GetComponent<Animator>(),new IntValue(1));
        moveManager.Add(MoveState.Main,enemy,move);
        moveManager.Add(MoveState.Atack,enemy,move);
    }

}