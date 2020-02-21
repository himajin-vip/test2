using UnityEngine;
public class Player:Charactor
{
    
    public Player(){
        DataCounter.AddCounters(new StatusCounter());
    }
    public void Set(){
        EfectControler = new EfectControler(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.tag == "Item"){
        // DropItemObj dropItemObj = collision.gameObject.GetComponent<DropItemObj>();
        // dropItemObj.DropEnd();
        // ItemBag itemBag = dropItemObj.GetItemBag();
        // new AddDropItem().Add(itemBag);
        // new ItemGetLog(Name,new Get_ItemID().forItemBag(itemBag));
        // new PlayAudio().Play(AudioList.ItemGet);
      }
      if(collision.gameObject.tag == "Npc"){
        // Npc = collision.GetComponent<Npc>();
        // TalkFlag = true;
      }
    }
    void OnTriggerExit2D(Collider2D collision){
      if(collision.gameObject.tag == "Npc"){
        // TalkFlag = false;
        // collision.GetComponent<Npc>().End();
      }
    }

}