using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Manager : MonoBehaviour
{
  public Slider hpSlider;
  public Text hpText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      hpSlider.maxValue = PlayerManager.Player.GetComponent<Player>().MaxHp;
      hpSlider.value = PlayerManager.Player.GetComponent<Player>().CurrentHp;
      hpText.text = PlayerManager.Player.GetComponent<Player>().CurrentHp+"/"+PlayerManager.Player.GetComponent<Player>().MaxHp;
    }
}
