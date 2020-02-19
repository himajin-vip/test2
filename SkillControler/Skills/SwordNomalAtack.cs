using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordNomalAtack:Skill
{
  GameObject Weapon;
  int xmargin = 20;
  int ymargin = 30;
  bool SetUp = false;

    public void On(PlayerObjectManager player,List<Enemy> hitList){
      if(!SetUp){
        Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");
      }

      int Direction = player.GetDirection();

      GameObject WeaponObject;
      Animator WeaponAnimator;
      float WeaponPositionx;
      float WeaponPositiony;
      float playerposx = player.GetPosX();
      float playerposy = player.GetPosY();
      switch(Direction){
        case 0:
          WeaponPositionx = playerposx+xmargin;
          WeaponPositiony = playerposy-ymargin;

          WeaponObject = new WeaponInstantiate().Get(Weapon,WeaponPositionx,WeaponPositiony,hitList);
          WeaponObject.transform.Rotate (0, 0,20);
          WeaponObject.transform.Find("Sword0").gameObject.SetActive(true);
          WeaponAnimator = WeaponObject.GetComponent<Animator>();
          WeaponAnimator.SetInteger("Direction",Direction);
        break;
        case 1:
          WeaponPositionx = playerposx-xmargin;
          WeaponPositiony = playerposy+ymargin;

          WeaponObject = new WeaponInstantiate().Get(Weapon,WeaponPositionx,WeaponPositiony,hitList);
          WeaponObject.transform.Rotate (0, 0,20);
          WeaponObject.transform.Find("Sword1").gameObject.SetActive(true);
          WeaponAnimator = WeaponObject.GetComponent<Animator>();
          WeaponAnimator.SetInteger("Direction",Direction);
        break;
        case 2:
          WeaponPositionx = playerposx+xmargin;
          WeaponPositiony = playerposy+ymargin;

          WeaponObject = new WeaponInstantiate().Get(Weapon,WeaponPositionx,WeaponPositiony,hitList);
          WeaponObject.transform.Rotate (0, 0,20);
          WeaponObject.transform.Find("Sword2").gameObject.SetActive(true);
          WeaponAnimator = WeaponObject.GetComponent<Animator>();
          WeaponAnimator.SetInteger("Direction",Direction);
        break;
        case 3:
          WeaponPositionx = playerposx-xmargin;
          WeaponPositiony = playerposy+ymargin;

          WeaponObject = new WeaponInstantiate().Get(Weapon,WeaponPositionx,WeaponPositiony,hitList);
          WeaponObject.transform.Rotate (0, 0,-20);
          WeaponObject.transform.Find("Sword3").gameObject.SetActive(true);
          WeaponAnimator = WeaponObject.GetComponent<Animator>();
          WeaponAnimator.SetInteger("Direction",Direction);
        break;
      }

    }


}
