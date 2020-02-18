public class StatusKey:Key
{
    public StatusKey(string Statuss ,string CaractorDataTypes){
        DataType = new DataType(CaractorDataTypes);
        StringValue = Statuss;
    }
    public override Key Copy(){
        return new StatusKey(StringValue,DataType.GetStringValue());
    }

}