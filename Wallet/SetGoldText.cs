using UnityEngine.UI;

public class SetGoldText
{
     public void Set(Text goldtext){
      Gold gold = new GetGold().Get();
      goldtext.text = new FirstintClasstoStringer().Get(gold)+"G";
    }
}
