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

  public void update(Playerp Playerp)
  {
    // LVText.text = "Lv:"+Playerp.Status.Lv+" "+Playerp.Name;
    // hpSlider.maxValue = Playerp.Status.Hp.maxValue;
    // hpSlider.value = Playerp.Status.Hp.currentValue;
    // hpText.text = Playerp.Status.Hp.currentValue+"/"+Playerp.Status.Hp.maxValue;
    // mpSlider.maxValue = Playerp.Status.Mp.maxValue;
    // mpSlider.value = Playerp.Status.Mp.currentValue;
    // mpText.text = Playerp.Status.Mp.currentValue+"/"+Playerp.Status.Mp.maxValue;

  }

}
