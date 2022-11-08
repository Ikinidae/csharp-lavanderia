public abstract class Macchina
{
    //properties
    public string Nome { get; set;  }
    public bool InFunzione { get; set; }
    public float Incasso { get; set; }
    public string ProgrammaInCorso { get; set; }
    public int DurataProgrammaInCorso { get; set; }

    //costruttore
    public Macchina (string nome)
    {
        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
        Incasso = 0;

    }
}