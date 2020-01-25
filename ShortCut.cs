using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShortCut : MonoBehaviour
{
  public Image imgShortcut1;
  public Text textShortcut1;
  public GameObject objShortcut1;
  public int IDShortcut1 = 0;

    public void update()
    {
      textShortcut1.text = InventoryManager.ReturnPieces(IDShortcut1)+"個";
    }
    public void ItemUse(){
      PlayerManager.Player.GetComponent<Player>().ItemUse(IDShortcut1);
    }
}
