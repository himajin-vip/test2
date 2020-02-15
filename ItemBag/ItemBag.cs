using UnityEngine;
public class ItemBag　:　IData
{
    public ItemBag(Key key, Value value){
        Key = key;
        Value = value; 
    }
    public override IData Copy(){
        return new ItemBag(Key.Copy(),Value.Copy());
    }     
}
