﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCheck
{
    public void Playerp(GameObject PlayerpObj,string enemyname,int enemylv ,int enemystr){
        // Damage Damage = new Damage();
        // Playerp Playerp = PlayerpObj.GetComponent<Playerp>();
        // string Playerpname = Playerp.Name;
        // // int Playerplv = Playerp.Status.Lv;
        // // int Playerpvit = Playerp.Status.Vit.Value;
        // Transform Playerptransform = PlayerpObj.transform;
        // /////ダメージ計算
        // int FinalDamage = Damage.Check(enemylv,enemystr,Playerplv,Playerpvit);
        // /////フィールドテキスト生成
        // FiledText filedText = new FiledText();
        // filedText.Make(FinalDamage.ToString(),new Color(255,0,0),Playerptransform);
        // ////ダメージを与える
        // Playerp.Status.Hp.Damage(FinalDamage);
    }

    public void Enemy(Player Player,Enemy enemy,int ExDamage){
    }
}
