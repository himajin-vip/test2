public class StatusValue:Value
{
    public StatusValue(int value){
        IntValue = value;
        StringValue = value.ToString();
    }
    public override bool Reduce(Value val){
        if(IntValue<val.GetIntValue()){
            IntValue = 0;
            return true;
        }
        IntValue -= val.GetIntValue();
        return true;
    }
    public override Value Copy(){
        return new StatusValue(IntValue);
    }
}