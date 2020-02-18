using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip
{
  Playerp Playerp;
  public Dictionary<ItemType,EquipPart> Parts{get; private set;} = new Dictionary<ItemType,EquipPart>(){
    {ItemType.Weapon,new EquipPart()},
    {ItemType.Head,new EquipPart()},
    {ItemType.Body,new EquipPart()},
    {ItemType.Hand,new EquipPart()},
    {ItemType.Foot,new EquipPart()},
    {ItemType.Accessory,new EquipPart()},
  };

  public Equip(Playerp Playerp){
    // Playerp = Playerp;
  }


public void PartSet(int ItemId,ItemType itemType){
  if(Parts[itemType].ItemId != 9999){
    Parts[itemType].UnSet(Parts[itemType].ItemId,Playerp);
  }
    Parts[itemType].Set(ItemId,Playerp);
    AccountData.Save();
}

public void PartsLoad(int ItemId,ItemType itemType){
  if(Parts[itemType].ItemId != 9999){
    Parts[itemType].UnSet(Parts[itemType].ItemId,Playerp);
  }
    Parts[itemType].Set(ItemId,Playerp);
}









}
