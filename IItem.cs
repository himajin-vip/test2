using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem
{
  void ItemUse(GameObject obj);
  void ItemSet();
  int ItemGet();
}
