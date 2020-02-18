public class StatusData:Data
{
    public StatusData(Key key,Value value){
        Key = key;
        Value = value;
    }
    public override Data Copy(){
        return new StatusData(Key.Copy(),Value.Copy());
    }
}