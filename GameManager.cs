using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      ItemManager.SetItemList();
    }

    // Update is called once per frame
    void Update()
    {
      EnemyManager.MakeEnemy("slime");
    }

}
