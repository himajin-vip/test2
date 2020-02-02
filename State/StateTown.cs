using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateTown : UpdateState
{

      public void Start()
      {

      }

      public void Update()
      {
        PlayerManager.PlayerDeathCheck();
        CameraManager.PlayerPosCheck();
        ControlManager.KeyCheck();
        UI_Manager.UiStatusUpdate();
        ShortcutManager.AllPiecesReset();
      }
      public void End(){

      }
}
