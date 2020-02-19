using UnityEngine;
using System.Collections.Generic;
public class SkillControler
{
    Dictionary<Skills,Skill> SkillList = new Dictionary<Skills, Skill>();
    Skill skill;
    public SkillControler(){
        SkillList.Add(Skills.SwordNomalAtack,new SwordNomalAtack());
        skill = SkillList[Skills.SwordNomalAtack];
    }
    public void SkillOn(PlayerObjectManager player){
        skill.On(player);
    }

    public void SetSkill(Skills setskill){
        skill = SkillList[setskill];
    }

}