using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvUpLog
{
  public LvUpLog(string Name){
    string newlog = (Name+"はLVが上がった");
    AudioManager.AudioON(9);
    LogManager.MakeLog(newlog);
  }
}
