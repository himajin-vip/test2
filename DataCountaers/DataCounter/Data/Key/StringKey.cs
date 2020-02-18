public class StringKey:Key
{
    public StringKey(string value ,string dataType){
        StringValue = value.ToString();
        DataType = new DataType(dataType);
    }
    public override Key Copy(){
        return new StringKey(StringValue,DataType.GetStringValue());
    }
}