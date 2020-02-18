public class MakeCharactor
{
    public Charactor Player(){
        StatusCounter statusCounter = new StatusCounter();
        return new Player(statusCounter);
    }
}