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
    LVText.text = "Lv:"+GameManager.Player.Lv.Value+" "+GameManager.Player.Name.Value;
    hpSlider.maxValue = GameManager.Player.Hp.maxValue;
    hpSlider.value = GameManager.Player.Hp.currentValue;
    hpText.text = GameManager.Player.Hp.currentValue+"/"+GameManager.Player.Hp.maxValue;
    mpSlider.maxValue = GameManager.Player.Mp.maxValue;
    mpSlider.value = GameManager.Player.Mp.currentValue;
    mpText.text = GameManager.Player.Mp.currentValue+"/"+GameManager.Player.Mp.maxValue;

  }

}
