public class StringValue:Value
{
    public StringValue(string value){
        StringValue = value;
    }
    public override Value Copy(){
        return new StringValue(StringValue);
    }
}