using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCheck
{
    public void Player(string enemyname,int enemylv ,int enemystr){
        Damage Damage = new Damage();
        string playername = GameManager.Player.Name.Value;
        int playerlv = GameManager.Player.Lv.Value;
        int playervit = GameManager.Player.Vit.Value;
        Transform playertransform = GameManager.Player.GameObject.transform;
        /////ダメージ計算
        int FinalDamage = Damage.Check(enemylv,enemystr,playerlv,playervit);
        /////フィールドテキスト生成
        FiledText filedText = new FiledText();
        filedText.Make(FinalDamage.ToString(),new Color(255,0,0),playertransform);
        ////ダメージログ生成
        new DamageLog(playername,FinalDamage);
        ////ダメージを与える
        GameManager.Player.Hp.Damage(FinalDamage);
    }

    public bool Enemy(Enemy enemy,int ExDamage){
        if(!enemy.DeathCheck){
          Damage Damage = new Damage();
          int FinalDamage = Damage.Check(GameManager.Player.Lv.Value*ExDamage,GameManager.Player.Str.Value,enemy.Lv.Value,enemy.Vit.Value);
          FiledText filedText = new FiledText();
          filedText.Make(FinalDamage.ToString(),new Color(255,255,255),enemy.transform);
          new DamageLog(enemy.Name.Value,FinalDamage);
          enemy.Hp.Damage(FinalDamage);
          return true;
        }
        return false;
    }
}
