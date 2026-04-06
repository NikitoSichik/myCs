//using System.Xml.Linq;

//class Book
//{
//    private string Title;
//    private string Author;
//    private int Pages;
//    private int Year;

//    public Book(string title, string author, int pages, int year)
//    {
//        Title = title;
//        Author = author;
//        Pages = pages;
//        Year = year;
//    }
//    public virtual bool IsClass()
//    {
//        if(Year > 1950) return true;
//        else return false;
//    }
//    public override string ToString()
//    {
//        return $"Название: {Title}. Автор: {Author}. Страниц: {Pages}. год выхода: {year}";
//    }
//}

//class Magazine : Book
//{
//    public int number;
//    public string publishing;

//    public Magazine(string title, string author, int pages, int year, int number, string publishing)
//        : base(title, author, pages, year)
//    {
//        this.number = number;
//        this.publishing = publishing;
//    }

    //public override bool IsClassic()
    //{
    //    return false;
    //}

//    public override string ToString()
//    {
//        return $"{base.ToString()}. Номер выпуска: {number}. Издательство: {publishing}";
//    }
//}






//class trafficlights
//{
//    private LightState state;
//    public void SetLight(LightState state) => this.state = state;
//    public trafficlights() => state = new RedState();

//    public void Green() => state.Green(this);
//    public void Yellow() => state.Yellow(this);
//    public void Red() => state.Red(this);
//}

//class LightState
//{
//    public virtual void Green(trafficlights light) { }
//    public virtual void Yellow(trafficlights light) { }
//    public virtual void Red(trafficlights light) { }
//}

//class GreenState : LightState
//{
//    public virtual void Green(trafficlights light)
//    {
//        Console.WriteLine("уже зелёный");
//    }
//    public virtual void Yellow(trafficlights light)
//    {
//        Console.WriteLine("жёлтый");
//        light.SetLight(new YellowState());
//    }
//    public virtual void Red(trafficlights light)
//    {
//        Console.WriteLine("Красный");
//        light.SetLight(new RedState());
//    }
//}

//class YellowState : LightState
//{
//    public virtual void Green(trafficlights light)
//    {
//        Console.WriteLine("зелёный");
//        light.SetLight(new GreenState());
//    }
//    public virtual void Yellow(trafficlights light)
//    {
//        Console.WriteLine("уже жёлтый");
//        light.SetLight(new RedState());
//    }
//    public virtual void Red(trafficlights light)
//    {
//        Console.WriteLine("Красный");
//        light.SetLight(new RedState());
//    }
//}

//class RedState : LightState
//{
//    public virtual void Green(trafficlights light)
//    {
//        Console.WriteLine("зелёный");
//        light.SetLight(new GreenState());
//    }
//    public virtual void Yellow(trafficlights light)
//    {
//        Console.WriteLine("нельзя жёлтый");
//    }
//    public virtual void Red(trafficlights light)
//    {
//        Console.WriteLine("уже Красный");
//    }

//    class Program
//    {
//        static void Main()
//        {
//            trafficlights light = new trafficlights();
//            light.Green();
//            light.Red();
//            light.Yellow();
//        }
//    }
//}


//class MusicPlayer
//{
//    private PlayerState state;
//    public void SetState(PlayerState state) => this.state = state;
//    public MusicPlayer() => state = new StopedState();

//    public void Play() => state.Play(this);
//    public void Pause() => state.Pause(this);
//    public void Stop() => state.Stop(this);
//}

//class PlayerState
//{
//    public virtual void Play(MusicPlayer player) { }
//    public virtual void Pause(MusicPlayer player) { }
//    public virtual void Stop(MusicPlayer player) { }
//}

//class PlayingState : PlayerState
//{
//    public virtual void Play(MusicPlayer player) {
//        Console.WriteLine("музыка играет");
//    }
//    public virtual void Pause(MusicPlayer player) {
//        Console.WriteLine("пауза");
//        player.SetState(new PausedState());
//    }
//    public virtual void Stop(MusicPlayer player) {
//        Console.WriteLine("Остановка");
//        player.SetState(new StopedState());
//    }
//}

//class PausedState : PlayerState
//{
//    public virtual void Play(MusicPlayer player)
//    {
//        Console.WriteLine("воспроизводить музыку");
//        player.SetState(new PlayingState());
//    }
//    public virtual void Pause(MusicPlayer player) {
//        Console.WriteLine("пауза");
//        player.SetState(new StopedState());
//    }
//    public virtual void Stop(MusicPlayer player) {
//        Console.WriteLine("Остановка");
//        player.SetState(new StopedState());
//    }
//}

//class StopedState : PlayerState
//{
//    public virtual void Play(MusicPlayer player)
//    {
//        Console.WriteLine("воспроизводить музыку");
//        player.SetState(new PlayingState());
//    }
//    public virtual void Pause(MusicPlayer player)
//    {
//        Console.WriteLine("нельзя пауза");
//    }
//    public virtual void Stop(MusicPlayer player)
//    {
//        Console.WriteLine("уже оставновленно");
//    }

//    class Program
//    {
//        static void Main()
//        {
//            MusicPlayer player = new MusicPlayer();
//            player.Play();
//            player.Stop();
//            player.Pause();
//        }
//    }
//}