using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ShortCut : MonoBehaviour
{
  public GameObject ImgObj;
  public Image imgShortcut;
  public Text textShortcut;
  public int IDShortcut=9999;
    public void SetUp(){
      imgShortcut = ImgObj.GetComponent<Image>();
      textShortcut.text = "";
    }
    public void ItemUse(){
      PlayerManager.ItemUse(IDShortcut);
    }

    public void PiecesReset(){
      textShortcut.text = InventoryManager.ReturnPieces(IDShortcut).ToString();
    }

    public void SetId(int ID){
      IDShortcut = ID;
      imgShortcut.color = new Color(1, 1, 1, 1);
      imgShortcut.sprite = ItemManager.ReturnImage(ID);
    }
}
