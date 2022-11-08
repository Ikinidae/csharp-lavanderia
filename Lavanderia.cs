//Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servizi autonomamente di 5 Lavatrici e 5 Asciugatrici.
//I clienti che usufruiscono delle macchine, possono effettuare diversi programmi di lavaggio e asciugatura ognuno con un costo diverso (in gettoni)
//e di una specifica durata. Ogni gettone costa 0.50 centesimi di euro e ogni lavaggio consuma detersivo e ammorbidente dai serbatoi della lavatrice.
//Ogni lavatrice può tenere fino ad un massimo di 1 litro di detersivo e 500ml di ammorbidente.
//I programmi di lavaggio hanno quindi queste caratteristiche
//Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
//Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
//Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.

//Le asciugatrici invece hanno soltanto due programmi di asciugatura, rapido 2 gettoni e intenso 4 gettoni della durata di 30 minuti e 60 minuti
//rispettivamente.

//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e quali non lo sono
//(in lavaggio / asciugatura oppure ferme)
//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario
//(in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio, tempo rimanente alla fine del
//lavaggio.
//3 - l’attuale incasso generato dall’utilizzo delle macchine.


//creo lavanderia che al suo interno crea le macchine

//stampo lo stato delle macchine

//interrogo le singole macchine
//classe lavanderia
using System.Security.Cryptography.X509Certificates;

public class Lavanderia
{
    public Lavatrice[] Lavatrici { get; }
    public Asciugatrice[] Asciugatrici { get; }

    //costruttore
    public Lavanderia()
    {

        Lavatrici = new Lavatrice[5];

        Lavatrici[0] = new Lavatrice("Lavatrice 1");
        Lavatrici[1] = new Lavatrice("Lavatrice 2");
        Lavatrici[2] = new Lavatrice("Lavatrice 3");
        Lavatrici[3] = new Lavatrice("Lavatrice 4");
        Lavatrici[4] = new Lavatrice("Lavatrice 5");

        Asciugatrici = new Asciugatrice[5];

        Asciugatrici[0] = new Asciugatrice("Asciugatrice 1");
        Asciugatrici[1] = new Asciugatrice("Asciugatrice 2");
        Asciugatrici[2] = new Asciugatrice("Asciugatrice 3");
        Asciugatrici[3] = new Asciugatrice("Asciugatrice 4");
        Asciugatrici[4] = new Asciugatrice("Asciugatrice 5");
    }


    public void StatoMacchine ()
    {
        //per stampare le lavatrici
        Console.WriteLine("STATO LAVATRICI:");
        for (int i = 0; i < Lavatrici.Length; i++)
        {
            Console.WriteLine ("Nome lavatrice: " + Lavatrici[i].Nome);
            Console.WriteLine("Incasso lavatrice: " + Lavatrici[i].Incasso);
            if (Lavatrici[i].InFunzione)
            {
                Console.WriteLine("Stato: in lavaggio");
                Console.WriteLine("Programma lavatrice: " + Lavatrici[i].ProgrammaInCorso);
            }
            else
            {
                Console.WriteLine("Stato: inattiva");
            }
            Console.WriteLine("---------------------------------");
        }
        Console.WriteLine("---------------------------------");

        //per stampare le asciugatrici
        Console.WriteLine("STATO ASCIUGATRICI:");
        for (int i = 0; i < Asciugatrici.Length; i++)
        {
            Console.WriteLine("Nome asciugatrice: " + Asciugatrici[i].Nome);
            Console.WriteLine("Incasso asciugatrice: " + Asciugatrici[i].Incasso);
            if (Asciugatrici[i].InFunzione)
            {
                Console.WriteLine("Stato: in asciugatura");
                Console.WriteLine("Programma asciugatrice: " + Asciugatrici[i].ProgrammaInCorso);
            }
            else
            {
                Console.WriteLine("Stato: inattiva");
            }
            Console.WriteLine("---------------------------------");
        }
    }

    public void AssegnaProgramma()
    {
        for (int i = 0; i < Lavatrici.Length; i++)
        {
            if (Lavatrici[i].InFunzione)
            {
                Random rnd = new Random();
                int rndInt = rnd.Next(0, 3);
                Lavatrici[i].ProgrammaInCorso = Lavatrici[i].ProgrammiLavatrice[rndInt].Nome;
                Lavatrici[i].DurataProgrammaInCorso = Lavatrici[i].ProgrammiLavatrice[rndInt].Durata;
            }
        }

        for (int i = 0; i < Asciugatrici.Length; i++)
        {
            if (Asciugatrici[i].InFunzione)
            {
                Random rnd = new Random();
                int rndInt = rnd.Next(0, 2);
                Asciugatrici[i].ProgrammaInCorso = Asciugatrici[i].ProgrammiAsciugatrice[rndInt].Nome;
                Asciugatrici[i].DurataProgrammaInCorso = Asciugatrici[i].ProgrammiAsciugatrice[rndInt].Durata;
            }
        }
    }



    public void InterrogaMacchine(string interrogazione)
    {
        if (interrogazione == "lavatrice")
        {
            Console.WriteLine("Scegli la lavatrice [1,2,3,4,5]");
            int lavatriceScelta = Convert.ToInt32(Console.ReadLine());
            if (lavatriceScelta > 0 && lavatriceScelta < 6)
            {
                Console.WriteLine("nome lavatrice: " + Lavatrici[lavatriceScelta - 1].Nome);
                if (Lavatrici[lavatriceScelta - 1].InFunzione)
                {
                    Console.WriteLine("Stato: In lavaggio");
                }
                else
                {
                    Console.WriteLine("Stato: inattiva");
                }
                Console.WriteLine("stato serbatoio detersivo: " + Lavatrici[lavatriceScelta - 1].SerbatoioDetersivo);
                Console.WriteLine("stato serbatoio ammorbidente: " + Lavatrici[lavatriceScelta - 1].SerbatoioAmmorbidente);
                Console.WriteLine("programma in funzione: " + Lavatrici[lavatriceScelta - 1].ProgrammaInCorso);
                Console.WriteLine("durata programma: " + Lavatrici[lavatriceScelta - 1].DurataProgrammaInCorso + " minuti");
                Console.WriteLine("l'incasso è: " + Lavatrici[lavatriceScelta - 1].Incasso);
            }
            else
            {
                Console.WriteLine("inserisci un numero valido");
                InterrogaMacchine(interrogazione);
            }
        }
        else if (interrogazione == "asciugatrice")
        {
            Console.WriteLine("Scegli l'asciugatrice [1,2,3,4,5]");
            int asciugatriceScelta = Convert.ToInt32(Console.ReadLine());
            if (asciugatriceScelta > 0 && asciugatriceScelta < 6)
            {
                Console.WriteLine("nome asciugatrice: " + Asciugatrici[asciugatriceScelta - 1].Nome);
                if (Asciugatrici[asciugatriceScelta - 1].InFunzione)
                {
                    Console.WriteLine("Stato: In asciugatura");
                }
                else
                {
                    Console.WriteLine("Stato: inattiva");
                }
                Console.WriteLine("programma in funzione: " + Asciugatrici[asciugatriceScelta - 1].ProgrammaInCorso);
                Console.WriteLine("durata programma: " + Asciugatrici[asciugatriceScelta - 1].DurataProgrammaInCorso + " minuti");
                Console.WriteLine("l'incasso è: " + Asciugatrici[asciugatriceScelta - 1].Incasso);
            }
            else
            {
                Console.WriteLine("fai una scelta appropriata");
                InterrogaMacchine(interrogazione);
            }
        }
        else
        {
            Console.WriteLine("fai una scelta appropriata");
            InterrogaMacchine(interrogazione);
        }
    }


    public void IncassoTotale ()
    {
        //totale lavatrici
        float totLavatrici = 0;
        foreach (Lavatrice lavatrice in Lavatrici)
        {
            totLavatrici += lavatrice.Incasso;
        }
        Console.WriteLine("L'attuale incasso delle lavatrici è: " + totLavatrici);

        //totale asciugatrici
        float totAsciugatrici = 0;
        foreach (Asciugatrice asciugatrice in Asciugatrici)
        {
            totAsciugatrici += asciugatrice.Incasso;
        }
        Console.WriteLine("L'attuale incasso delle asciugatrici è: " + totAsciugatrici);

        //totale macchine
        Console.WriteLine("L'attuale incasso di tutte le macchine è: " + (totAsciugatrici + totLavatrici));

    }
}

