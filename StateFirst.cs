using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StateFirst : UpdateState
{
  bool LoadEnd;
    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {

    }
    public void End(){
      UpdateManager.StartOff();
      UpdateManager.UpdateOff();
      SceneManager.sceneLoaded += SceneLoaded;
      SceneManager.LoadScene("Main");
    }

    public void SceneLoaded (Scene nextScene, LoadSceneMode mode) {
      UpdateManager.StartOn();
    }
}
