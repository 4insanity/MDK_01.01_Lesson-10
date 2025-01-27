

public interface ISelectable
{
    public void OnSelect();
}

public interface IUpdatable
{
    public void Refresh();
   
}


public class Screen : ISelectable, IUpdatable
{

    public void OnSelect()
    {
        Console.WriteLine("Выбрано");
    }
    public void Refresh()
    {
        Console.WriteLine("Обновлено");
    }
    
}


class Programm
{
    static void Main(string[] args)
    {
        Screen screen = new Screen();
        screen.OnSelect();
        screen.Refresh();
    }
}