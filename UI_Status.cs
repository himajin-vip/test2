using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Status : MonoBehaviour
{
  public Slider hpSlider;
  public Text hpText;

  public void update()
  {
    hpSlider.maxValue = PlayerManager.Player.GetComponent<Player>().MaxHp;
    hpSlider.value = PlayerManager.Player.GetComponent<Player>().CurrentHp;
    hpText.text = PlayerManager.Player.GetComponent<Player>().CurrentHp+"/"+PlayerManager.Player.GetComponent<Player>().MaxHp;
  }

}
