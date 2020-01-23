using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShortcutManager : MonoBehaviour
{
  public Image imgShortcut1;
  public Text textShortcut1;
  public GameObject objShortcut1;
  public int IDShortcut1 = 0;
  public Player Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      textShortcut1.text = InventoryManager.ReturnPieces(IDShortcut1)+"個";
    }
    public void ItemUse(){
      Player.ItemUse(IDShortcut1);
    }
}
