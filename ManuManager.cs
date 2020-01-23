using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuManager : MonoBehaviour
{
  public GameObject MenuCanvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ManuOn(){
      MenuCanvas.gameObject.SetActive(true);
    }

    public void OnClick(int num){
      switch(num){
        case 0:
          MenuCanvas.gameObject.SetActive(false);
        break;
      }
    }
}
