public class NullValue:Value{
public NullValue(int i = 0,string s = ""){
    IntValue = i;
    StringValue = s;
}
public override Value Copy(){
    return new NullValue();
}
}