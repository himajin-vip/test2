using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UI_Manager
{
  private static UI_Status UiStatus;

  public static void SetUp(){
    UiStatus = GameObject.Find("StatusCanvas").GetComponent<UI_Status>();
  }
  public static void UiStatusUpdate(){
    UiStatus.update();
  }


}
