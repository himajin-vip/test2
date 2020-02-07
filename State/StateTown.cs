using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateTown : UpdateState
{

      public void Start()
      {
        ControlManager.KeyChenge("Town");
      }

      public void Update()
      {
        PlayerManager.PlayerDeathCheck();
        CameraManager.PlayerPosCheck();
        ControlManager.Check();
        UI_Manager.UiStatusUpdate();
        ShortcutManager.AllPiecesReset();
      }
      public void End(){

      }
}
