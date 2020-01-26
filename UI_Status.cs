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
  public Text NameText;

  public void update()
  {
    NameText.text = PlayerManager.Player.Name;
    LVText.text = "Lv:"+PlayerManager.Player.Level;
    hpSlider.maxValue = PlayerManager.Player.MaxHp;
    hpSlider.value = PlayerManager.Player.CurrentHp;
    hpText.text = PlayerManager.Player.CurrentHp+"/"+PlayerManager.Player.MaxHp;
    mpSlider.maxValue = PlayerManager.Player.MaxMp;
    mpSlider.value = PlayerManager.Player.CurrentMp;
    mpText.text = PlayerManager.Player.CurrentMp+"/"+PlayerManager.Player.MaxMp;

  }

}
