using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCheck
{
    public void Player(GameObject PlayerObj,string enemyname,int enemylv ,int enemystr){
        Damage Damage = new Damage();
        Player player = PlayerObj.GetComponent<Player>();
        string playername = player.Name;
        int playerlv = player.Status.Lv.Value;
        int playervit = player.Status.Vit.Value;
        Transform playertransform = PlayerObj.transform;
        /////ダメージ計算
        int FinalDamage = Damage.Check(enemylv,enemystr,playerlv,playervit);
        /////フィールドテキスト生成
        FiledText filedText = new FiledText();
        filedText.Make(FinalDamage.ToString(),new Color(255,0,0),playertransform);
        ////ダメージログ生成
        new DamageLog(playername,FinalDamage);
        ////ダメージを与える
        player.Status.Hp.Damage(FinalDamage);
    }

    public bool Enemy(Player player,Enemy enemy,int ExDamage){
        if(!enemy.DeathCheck){
          Damage Damage = new Damage();
          enemy.player = player;
          int FinalDamage = Damage.Check(player.Status.Lv.Value*ExDamage,player.Status.Str.Value,enemy.Lv.Value,enemy.Vit.Value);
          FiledText filedText = new FiledText();
          filedText.Make(FinalDamage.ToString(),new Color(255,255,255),enemy.transform);
          new DamageLog(enemy.Name,FinalDamage);
          enemy.Hp.Damage(FinalDamage);
          return true;
        }
        return false;
    }
}
