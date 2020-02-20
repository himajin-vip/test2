using UnityEngine;
using System.Collections.Generic;
public class SkillControler
{
    SkillChenger skillChenger = new SkillChenger();
    bool On = false;
    public void SkillOn(PlayerObjectManager player){
        if(!On){
            skillChenger.SkillOn(player);
            player.GetPlayer().EfectOff(Efects.tame);
            On = true;
        }
    }

    public void SetSkill(Skills setskill){
        skillChenger.SetSkill(setskill);
    }
    public void DamageCheck(Player player,List<Enemy> hitList){
        skillChenger.DamageCheck(player,hitList);
        On = false;
    }

}