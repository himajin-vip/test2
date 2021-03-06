using UnityEngine;
public abstract class Charactor: MonoBehaviour
{
    protected DataCounterService DataCounter = new DataCounterService();
    protected EfectControler EfectControler;
    public Value GetStatus(Statuss status){
        return DataCounter.GetValue(new StringKey(status.ToString(),DataType_Charactor.Status.ToString()));
    }
    public void LoadStatus(Statuss status,Value value){
        DataCounter.Add(new StringKey(status.ToString(),DataType_Charactor.Status.ToString()),value);
    }
    public GameObject GetObj(){
        return this.gameObject;
    }
    public void SetEfect(Efects efects){
        EfectControler.On(efects);
    }
    public void EfectOff(Efects efects){
        EfectControler.End(efects);
    }
    public void EfectCount(){
        EfectControler.Count();
    }
    public bool ReduceStatusValue(Statuss status,IntValue value){
        Key key = new StringKey(status.ToString(),DataType_Charactor.Status.ToString());
        return DataCounter.Reduce(key,value);
    }
    public void DethCheck(){
        Value Hp = GetStatus(Statuss.CurrentHp);
        if(Hp.GetIntValue()==0){
            GameManager.SetState(States.DethCheck,new DethCheckData(this));
        }
    }

}