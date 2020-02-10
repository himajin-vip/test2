using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager
{
  private static UI_Status UiStatus;
  public static TalkCanvas TalkCanvas = new TalkCanvas();

  public UI_Manager(){
    UiStatus = GameObject.Find("StatusCanvas").GetComponent<UI_Status>();
  }
  public static void StatusUpdate(){
    UiStatus.update();
  }


}
