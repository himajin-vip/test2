using UnityEngine;
using System.Collections.Generic;
public class SkillControler
{
    SkillChenger skillChenger = new SkillChenger();
    List<Enemy> hitList;
    bool On = false;
    public SkillControler(List<Enemy> list){
        hitList = list;
    }
    public void SkillOn(PlayerObjectManager player){
        if(!On){
            skillChenger.SkillOn(player,hitList);
            player.GetPlayer().EfectOff(Efects.tame);
            On = true;
        }
    }

    public void SetSkill(Skills setskill){
        skillChenger.SetSkill(setskill);
    }
    public void DamageCheck(Player player){
        skillChenger.DamageCheck(player,hitList);
        On = false;
    }

}