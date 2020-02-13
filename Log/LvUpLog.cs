using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvUpLog:LogMaker
{
  public LvUpLog(string Name){
    string newlog = (Name+"はLVが上がった");
    new PlayAudio().Play(AudioList.LVUP);
    logCanvas.MakeLog(newlog);
  }
}
