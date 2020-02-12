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

  public void update(Player player)
  {
    LVText.text = "Lv:"+player.Status.Lv+" "+player.Name;
    hpSlider.maxValue = player.Status.Hp.maxValue;
    hpSlider.value = player.Status.Hp.currentValue;
    hpText.text = player.Status.Hp.currentValue+"/"+player.Status.Hp.maxValue;
    mpSlider.maxValue = player.Status.Mp.maxValue;
    mpSlider.value = player.Status.Mp.currentValue;
    mpText.text = player.Status.Mp.currentValue+"/"+player.Status.Mp.maxValue;

  }

}
