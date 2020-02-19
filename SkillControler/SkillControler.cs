using UnityEngine;
using System.Collections.Generic;
public class SkillControler
{
    SkillChenger skillChenger = new SkillChenger();
    List<Enemy> hitList;
    public SkillControler(List<Enemy> list){
        hitList = list;
    }
    public void SkillOn(PlayerObjectManager player){
        skillChenger.SkillOn(player,hitList);
    }

    public void SetSkill(Skills setskill){
        skillChenger.SetSkill(setskill);
    }
    public void DamageCheck(Player player){
        skillChenger.DamageCheck(player,hitList);
    }

}