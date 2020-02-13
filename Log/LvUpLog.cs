using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvUpLog:LogMaker
{
  public LvUpLog(string Name){
    string newlog = (Name+"はLVが上がった");
    AudioManager.AudioON(9);
    logCanvas.MakeLog(newlog);
  }
}
