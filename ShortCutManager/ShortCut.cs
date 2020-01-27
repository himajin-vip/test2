using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShortCut : MonoBehaviour
{
  public Image imgShortcut;
  public Text textShortcut;
  private int IDShortcut = 0;

    public void ItemUse(){
      PlayerManager.ItemUse(IDShortcut);
    }
    public void Reset(){
      textShortcut.text = InventoryManager.ReturnPieces(IDShortcut)+"個";
    }
    public void SetIDShortcut(int ID){
      IDShortcut = ID;
    }
}
