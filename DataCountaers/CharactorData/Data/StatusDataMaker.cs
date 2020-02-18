public class StatusDataMaker{
    public Data IntMake(Statuss status,CharactorDataTypes datatype,int Value){
        return new StatusData(new StatusKey(status.ToString(),datatype.ToString()),new StatusValue(Value));
    }
    public Data StringMake(Statuss status,CharactorDataTypes datatype,string Value){
        return new StatusData(new StatusKey(status.ToString(),datatype.ToString()),new StatusValue(-1,Value));
    }
}