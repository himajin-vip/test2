using UnityEngine;
using System.Collections.Generic;
public class SkillChenger
{
    Dictionary<Skills,Skill> SkillList = new Dictionary<Skills, Skill>();
    Skill skill;
    public SkillChenger(){
        SkillList.Add(Skills.SwordNomalAtack,new SwordNomalAtack());
        skill = SkillList[Skills.SwordNomalAtack];
    }
    public void SkillOn(PlayerObjectManager player,List<Enemy> hitList){
        skill.On(player,hitList);
    }

    public void SetSkill(Skills setskill){
        skill = SkillList[setskill];
    }
    public void DamageCheck(Player player,List<Enemy> list){
        skill.DamageCheck(player,list);
    }
}