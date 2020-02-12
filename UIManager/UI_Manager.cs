using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager
{
  private static UI_Status UiStatus;
  public static TalkCanvas TalkCanvas;

  public void SetUp(){
    UiStatus = GameObject.Find("StatusCanvas").GetComponent<UI_Status>();
    TalkCanvas = new TalkCanvas();
  }
  public static void StatusUpdate(){
    UiStatus.update();
  }


}
