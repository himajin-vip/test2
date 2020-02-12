public class PlayerStatus
{
  public int Lv{get; protected set;}
  public StatusHp Hp{get; protected set;}
  public StatusMp Mp{get; protected set;}
  public StatusBattle Str{get; protected set;}
  public StatusBattle Vit{get; protected set;}
  public StatusBattle Dex{get; protected set;}
  public StatusBattle Int{get; protected set;}
  public StatusExp Exp{get; protected set;}

  public void LvUp(){
    Lv++;
    Hp.LvUp(50);
    Mp.LvUp(5);
    Str.LvUp(1);
    Vit.LvUp(1);
    Dex.LvUp(1);
    Int.LvUp(1);
  }

  public void SetNewGame(){
    Lv = 1;
    Hp = new StatusHp(100,100);
    Mp = new StatusMp(10,10);
    Str = new StatusBattle(1);
    Vit = new StatusBattle(1);
    Dex = new StatusBattle(1);
    Int = new StatusBattle(1);
    Exp = new StatusExp(100,0);
  }
  public void SetLoadGame(SaveData LoadData){
    Lv = LoadData.Lv;
    Hp = new StatusHp(LoadData.MaxHp,LoadData.CurrentHp);
    Mp = new StatusMp(LoadData.MaxMp,LoadData.CurrentMp);
    Str = new StatusBattle(LoadData.Str);
    Vit = new StatusBattle(LoadData.Vit);
    Dex = new StatusBattle(LoadData.Dex);
    Int = new StatusBattle(LoadData.Int);
    Exp = new StatusExp(LoadData.NextExp,LoadData.CurrentExp);
  }
  
}
