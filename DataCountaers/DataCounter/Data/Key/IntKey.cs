public class IntKey:Key
{
    public IntKey(int value ,string dataType){
        IntValue = value;
        StringValue = value.ToString();
        DataType = new DataType(dataType);
    }
    public override Key Copy(){
        return new IntKey(IntValue,DataType.GetStringValue());
    }
}