//classe asciugatrice
public class Asciugatrice : Macchina
{
    //properties
    public ProgrammaAsciugatrice[] ProgrammiAsciugatrice { get; set; }

    //costruttore
    public Asciugatrice(string nome) : base(nome)
    {
        ProgrammiAsciugatrice = new ProgrammaAsciugatrice[2];
        ProgrammaAsciugatrice rapido = new ProgrammaAsciugatrice("Rapido", 2, 30);
        ProgrammaAsciugatrice intenso = new ProgrammaAsciugatrice("Intenso", 4, 60);

        ProgrammiAsciugatrice[0] = rapido;
        ProgrammiAsciugatrice[1] = intenso;
    }
}
