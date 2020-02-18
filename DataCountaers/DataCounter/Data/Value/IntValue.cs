public class IntValue:Value
{
    public IntValue(int value){
        IntValue = value;
        StringValue = value.ToString();
    }
    public override Value Copy(){
        return new IntValue(IntValue);
    }
}