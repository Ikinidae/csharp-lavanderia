public abstract class Macchina
{
    //properties
    public string Nome { get; }
    public bool InFunzione { get; }
    public float Incasso { get; }
    public string ProgrammaInCorso { get; set; }

    //costruttore
    public Macchina (string nome)
    {
        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
        Incasso = rnd.Next(501) * 0.50f;

    }

    //metodi
    public abstract string AssegnaProgramma();
}