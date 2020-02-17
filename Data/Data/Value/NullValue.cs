public class NullValue:Value{
public override Value Copy(){
    return new NullValue();
}
}