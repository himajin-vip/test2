public class StatusValue:Value
{
    public StatusValue(int intValue = -1, string stringValue = ""){
        IntValue = intValue;
        StringValue = stringValue;
        if(intValue != -1 && stringValue == ""){
            StringValue = intValue.ToString();
        }
    }
    public override Value Copy(){
        return new StatusValue(IntValue,StringValue);
    }
}