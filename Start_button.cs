using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_button : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
      SceneManager.LoadScene("Main");
    }

    // Update is called once per frame

}
