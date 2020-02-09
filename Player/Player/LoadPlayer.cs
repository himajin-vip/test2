using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : Player
{
    public LoadPlayer(){
        SaveData LoadData = GameManager.AccountData.LoadData;
        Name = new Name(LoadData.Name);
        Lv = new Lv(LoadData.Lv);
        Hp = new Hp(LoadData.MaxHp,LoadData.CurrentHp);
        Mp = new Mp(LoadData.MaxMp,LoadData.CurrentMp);
        Str = new Str(LoadData.Str);
        Vit = new Vit(LoadData.Vit);
        Dex = new Dex(LoadData.Dex);
        Int = new Int(LoadData.Int);
        Exp = new Exp(LoadData.NextExp,LoadData.CurrentExp);
        
        MoveSpeed = new MoveSpeed(3,1);

        Atack = new Atack();
        ChargeSkill = new SwordChargeAtack();
        NormalAtack = new SwordNomalAtack();
        Skill = NormalAtack;

        Equip = new Equip();
        Equip.PartSet(LoadData.EquipWeapon,ItemType.Weapon);
        Equip.PartSet(LoadData.EquipHead,ItemType.Head);
        Equip.PartSet(LoadData.EquipBody,ItemType.Body);
        Equip.PartSet(LoadData.EquipHand,ItemType.Hand);
        Equip.PartSet(LoadData.EquipFoot,ItemType.Foot);
        Equip.PartSet(LoadData.EquipAccessory,ItemType.Accessory);
    }
}
