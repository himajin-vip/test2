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
        FiledText filedText = new FiledText();
        filedText.Make(FinalDamage.ToString(),new Color(255,0,0),playertransform);
        ////ダメージログ生成
        new DamageLog(playername,FinalDamage);
        ////ダメージを与える
        PlayerManager.Player.Hp.Damage(FinalDamage);
    }

    public bool Enemy(Enemy enemy){
        if(!enemy.DeathCheck){
          Damage Damage = new Damage();
          int FinalDamage = Damage.Check(PlayerManager.Player.Lv.Value,PlayerManager.Player.Str.Value,enemy.Lv.Value,enemy.Vit.Value);
          FiledText filedText = new FiledText();
          filedText.Make(FinalDamage.ToString(),new Color(255,255,255),enemy.transform);
          new DamageLog(enemy.Name.Value,FinalDamage);
          enemy.Hp.Damage(FinalDamage);
          return true;
        }
        return false;
    }
}
