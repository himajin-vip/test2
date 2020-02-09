using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkCanvas
{
    private GameObject TalkWindow;
    private Text NameText;
    private Text MessageText;
    public void SetUp(){
        TalkWindow = GameObject.Find("TalkCanvas").transform.Find("TalkWindow").gameObject;
        NameText = GameObject.Find("TalkCanvas").transform.Find("TalkWindow").transform.Find("NameText").GetComponent<Text>();
        MessageText = GameObject.Find("TalkCanvas").transform.Find("TalkWindow").transform.Find("MessageText").GetComponent<Text>();
    }

    public void Set(string name , string message){
        TalkWindow.SetActive(true);
        NameText.text = name;
        MessageText.text = message;
    }
    public void End(){
        TalkWindow.SetActive(false);
        NameText.text = "";
        MessageText.text = "";
    }
}
