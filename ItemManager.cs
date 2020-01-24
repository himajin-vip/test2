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
    static public void DropItem(int key,float x,float y,MonoBehaviour i_behaviour){
      int rndx = Random.Range(-18000, 18000);
      int rndy =  Random.Range(18000, 18000);
      GameObject obj = ItemList[key];
      GameObject obj2 = Instantiate(obj, new Vector3(x,y,0), Quaternion.identity);
      obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(rndx,rndy));
      i_behaviour.StartCoroutine(StopItem(obj2));

    }
    private static IEnumerator StopItem(GameObject obj)
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("stop");
        obj.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        obj.GetComponent<Rigidbody2D>().isKinematic = true;
    }
}
