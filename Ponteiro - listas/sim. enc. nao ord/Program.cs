using System.Security.Cryptography;

class Elemento
{
    public int num;
    public Elemento prox;
}
class Lista
{
    private Elemento inicio;
    private Elemento fim;
    private Elemento ant;
    private Elemento aux;
    public Lista()
    {
        inicio = null;
        fim = null;
    }
    public void Inserir(int valor)
    {
        Elemento novo = new Elemento();
        novo.num = valor;
        if (inicio == null)
        {
            inicio = novo;
            fim = novo;
        }
        else
        {
            novo.prox = inicio;
            inicio = novo;
        }
    }
    public void InserirFim(int valor)
    {
        Elemento novo = new Elemento();
        novo.num = valor;
        if (inicio == null)
        {
            inicio = novo;
            fim = novo;
            fim.prox = null;
        }
        else
        {
            fim.prox = novo;
            fim = novo;
        }
    }
    public void MostraLista()
    {
        Console.Clear();
        aux = inicio;
        while (aux != null)
        {
            System.Console.Write($"{aux.num}\t");
            aux = aux.prox;
        }
        System.Console.WriteLine("");
    }
}
class Program
{
    static void Main()
    {
        Lista minhaLista = new Lista();
        int resp = 1000;
        int op, num;

        while (resp != 0)
        {
            System.Console.WriteLine("1 - Inserir Inicio\n2 - Inserir Fim\n3 - Mostrar Lista");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    System.Console.WriteLine("Insira o valor que deseja inserir");
                    num = int.Parse(Console.ReadLine());
                    minhaLista.Inserir(num);
                    break;
                case 2:
                    System.Console.WriteLine("Insira o valor que deseja inserir no fim");
                    num = int.Parse(Console.ReadLine());
                    minhaLista.InserirFim(num);
                    break;
                case 3:
                    minhaLista.MostraLista();
                    break;
                default:
                    System.Console.WriteLine("Insira uma opção válida");
                    break;
            }
        }
    }
}