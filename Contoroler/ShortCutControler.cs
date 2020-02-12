using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortCutControler
{
    public void Check(){
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            ShortcutManager.ShortCutOn(1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            ShortcutManager.ShortCutOn(2);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            ShortcutManager.ShortCutOn(3);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
            ShortcutManager.ShortCutOn(4);
        }
    }
}
