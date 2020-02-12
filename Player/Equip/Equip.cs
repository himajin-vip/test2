using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip
{
  Player Player;
  public Dictionary<ItemType,EquipPart> Parts{get; private set;} = new Dictionary<ItemType,EquipPart>(){
    {ItemType.Weapon,new EquipPart()},
    {ItemType.Head,new EquipPart()},
    {ItemType.Body,new EquipPart()},
    {ItemType.Hand,new EquipPart()},
    {ItemType.Foot,new EquipPart()},
    {ItemType.Accessory,new EquipPart()},
  };

  public Equip(Player player){
    Player = player;
  }


public void PartSet(int ItemId,ItemType itemType){
  if(Parts[itemType].ItemId != 9999){
    Parts[itemType].UnSet(Parts[itemType].ItemId,Player);
  }
    Parts[itemType].Set(ItemId,Player);
    AccountData.Save();
}

public void PartsLoad(int ItemId,ItemType itemType){
  if(Parts[itemType].ItemId != 9999){
    Parts[itemType].UnSet(Parts[itemType].ItemId,Player);
  }
    Parts[itemType].Set(ItemId,Player);
}









}
