using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
  public ItemID Id{get; protected set;}
  public ItemInfo Info{get; protected set;}
  public ItemType Type{get; protected set;}
  public ItemName Name{get; protected set;}
  public ItemPrice Price{get; protected set;}
}
