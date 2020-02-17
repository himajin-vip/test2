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
  public int IDShortcut{get; private set;}=9999;
    public void SetUp(){
      imgShortcut = ImgObj.GetComponent<Image>();
      textShortcut.text = "";
    }

    public void PiecesReset(){
      ItemID itemID = new ItemID(IDShortcut);
      // new InventoryPeaceTextSet().Set(textShortcut,itemID);
    }

    public void SetId(int ID){
      IDShortcut = ID;
      imgShortcut.color = new Color(1, 1, 1, 1);
      // imgShortcut.sprite = new GetItemImage().Get(new ItemID(ID));
    }
}
