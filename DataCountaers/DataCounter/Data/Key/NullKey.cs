public class NullKey:Key
{
    public override Key Copy(){
        return new NullKey();
    }
}