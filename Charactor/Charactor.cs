using UnityEngine;
public abstract class Charactor: MonoBehaviour
{
    protected DataCounterService DataCounter = new DataCounterService();
    public Value GetStatus(Statuss status){
        return DataCounter.GetValue(new StringKey(status.ToString(),DataType_Charactor.Status.ToString()));
    }
    public bool ReduceStatusValue(Statuss status,IntValue value){
        Key key = new StringKey(status.ToString(),DataType_Charactor.Status.ToString());
        return DataCounter.Reduce(key,value);
    }
    public bool DethCheck(){
        Key key = new StringKey(Statuss.CurrentHp.ToString(),DataType_Charactor.Status.ToString());
        Value Hp = DataCounter.GetValue(key);
        if(Hp.GetIntValue()==0){
            return true;
        }
        return false;
    }

}