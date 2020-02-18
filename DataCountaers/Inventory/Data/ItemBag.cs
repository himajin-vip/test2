using UnityEngine;
public class ItemBag　:　Data
{
    public ItemBag(Key key , Value value){
        Key = key;
        Value = value; 
    }
    public override Data Copy(){
        return new ItemBag(Key.Copy(),Value.Copy());
    }     
}
