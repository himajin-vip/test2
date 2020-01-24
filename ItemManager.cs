using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
  static Dictionary<int,GameObject> ItemList = new Dictionary<int,GameObject>();

    // Start is called before the first frame update
    void Start(){
      ItemList.Add(0,(GameObject)Resources.Load ("prefab/portion"));
    }

    // Update is called once per frame
    void Update(){
    }
    static public GameObject returnItemObject(int ItemID){
      return ItemList[ItemID];
    }
    static public void DropItem(int key,float x,float y){
      int rndx = Random.Range(-18000, 18000);
      int rndy =  Random.Range(18000, 18000);
      GameObject obj = ItemList[key];
      GameObject obj2 = Instantiate(obj, new Vector3(x,y,0), Quaternion.identity);
      obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(rndx,rndy));
      obj2.GetComponent<IItem>().DropItem();
    }

}
