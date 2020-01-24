﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      ItemManager.SetItemList();//アイテムリストの登録
      InventoryManager.SetUp();//インベントリの初期化
      EnemyManager.EnemyCurrentCount = 0;//モンスターの表示数の初期化
      PlayerManager.MakePlayer("Fighter");
    }

    // Update is called once per frame
    void Update()
    {
      EnemyManager.MakeEnemy("slime");
    }

}
