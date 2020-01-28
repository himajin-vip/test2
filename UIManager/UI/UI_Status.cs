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
    LVText.text = "Lv:"+PlayerManager.ReturnLv()+" "+PlayerManager.ReturnName();;
    hpSlider.maxValue = PlayerManager.ReturnMaxHp();
    hpSlider.value = PlayerManager.ReturnCurrentHp();
    hpText.text = PlayerManager.ReturnCurrentHp()+"/"+PlayerManager.ReturnMaxHp();
    mpSlider.maxValue = PlayerManager.ReturnMaxMp();
    mpSlider.value = PlayerManager.ReturnCurrentMp();
    mpText.text = PlayerManager.ReturnCurrentMp()+"/"+PlayerManager.ReturnMaxMp();

  }

}
