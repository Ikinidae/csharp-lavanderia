//classe programma
public abstract class Programma
{
    //properties
    public string Nome { get; set; }
    public int Costo { get; set; }
    public int Durata { get; set; }

    //costruttore
    public Programma (string nome, int costo, int durata)
    {
        Nome = nome;
        Costo = costo;
        Durata = durata;
    }
}
