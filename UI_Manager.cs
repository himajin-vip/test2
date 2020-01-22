using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Manager : MonoBehaviour
{
  public Slider hpSlider;
  public Text hpText;
  public Player_HP_Manager player_hp_manager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      hpSlider.maxValue = player_hp_manager.PlayerMaxHP;
      hpSlider.value = player_hp_manager.PlayerCurrentHP;
      hpText.text = player_hp_manager.PlayerCurrentHP+"/"+player_hp_manager.PlayerMaxHP;
    }
}
