using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endbutton : MonoBehaviour
{
    public void OnClick(){
      SceneManager.LoadScene("title");
      UpdateManager.StateSet("First");
    }
}
