using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Status : MonoBehaviour
{
  public Slider hpSlider;
  public Text hpText;
  public Slider mpSlider;
  public Text mpText;
  public Text LVText;

  public void update()
  {
    LVText.text = "Lv:"+PlayerManager.Player.Lv.Value+" "+PlayerManager.Player.Name.Value;
    hpSlider.maxValue = PlayerManager.Player.Hp.maxValue;
    hpSlider.value = PlayerManager.Player.Hp.currentValue;
    hpText.text = PlayerManager.Player.Hp.currentValue+"/"+PlayerManager.Player.Hp.maxValue;
    mpSlider.maxValue = PlayerManager.Player.Mp.maxValue;
    mpSlider.value = PlayerManager.Player.Mp.currentValue;
    mpText.text = PlayerManager.Player.Mp.currentValue+"/"+PlayerManager.Player.Mp.maxValue;

  }

}
