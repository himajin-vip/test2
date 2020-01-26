using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      UpdateManager.SetUp();
      UpdateManager.StateSet("Main");
    }

    // Update is called once per frame
    void Update()
    {
      UpdateManager.StateUpdate();
    }

}
