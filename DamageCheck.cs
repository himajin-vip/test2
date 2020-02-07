using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCheck
{
    public void Player(string enemyname,int enemylv ,int enemystr){
        Damage Damage = new Damage();
        string playername = PlayerManager.Player.Name.Value;
        int playerlv = PlayerManager.Player.Lv.Value;
        int playervit = PlayerManager.Player.Vit.Value;
        Transform playertransform = PlayerManager.Player.GameObject.transform;
        /////ダメージ計算
        int FinalDamage = Damage.Check(enemylv,enemystr,playerlv,playervit);
        /////フィールドテキスト生成
        FiledTextManager.Make(FinalDamage.ToString(),playertransform.position.x,playertransform.position.y,new Color(255,0,0),playertransform);
        ////ダメージログ生成
        new DamageLog(playername,FinalDamage);
        ////ダメージを与える
        PlayerManager.Player.Hp.Damage(FinalDamage);
    }

    public void Enemy(Enemy enemy){
        if(!enemy.DeathCheck){
          EfectManager.efecton("kiriefect",enemy.transform.position.x,enemy.transform.position.y,enemy.gameObject);
          Damage Damage = new Damage();
          int FinalDamage = Damage.Check(PlayerManager.Player.Lv.Value,PlayerManager.Player.Str.Value,enemy.Lv.Value,enemy.Vit.Value);
          FiledTextManager.Make(FinalDamage.ToString(),enemy.transform.position.x,enemy.transform.position.y,new Color(255,255,255),enemy.transform);
          new DamageLog(enemy.Name.Value,FinalDamage);
          enemy.Hp.Damage(FinalDamage);
        }
    }
}
