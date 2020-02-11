using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : Player
{
   public NewPlayer(){
        Name = new Name(GameManager.AccountData.Name);
        Lv = new Lv(1);
        Hp = new Hp(100,100);
        Mp = new Mp(10,10);
        Str = new Str(1);
        Vit = new Vit(1);
        Dex = new Dex(1);
        Int = new Int(1);
        Exp = new Exp(100,0);
        MoveSpeed = new MoveSpeed(3,1);

        Equip = new Equip();
        Atack = new Atack();

        ChargeSkill = new SwordChargeAtack();
        NormalAtack = new SwordNomalAtack();
        Skill = NormalAtack;


   }
}
