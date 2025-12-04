
class Elemento
{
    public int num;
    public Elemento prox;
}
class Lista
{
    private Elemento fim;
    private Elemento aux;
    private Elemento inicio;
    public Lista()
    {
        inicio = null;
        fim = null;
    }
    public void AddInicio(int valor)
    {
        Elemento novo = new Elemento();
        novo.num = valor;

        if (inicio == null) /* Se não houver elementos na lista, ele cria o primeiro, onde o início e o fim são o mesmo */
        {
            inicio = novo;
            fim = novo;
        }
        else
        {
            novo.prox = inicio; // O próximo numero depois do Elemento novo se torna o início,
            inicio = novo; // logo em sequência o início aponta para o novo, o novo se torna a referência de início
        }
    }
    public void AddFim(int valor)
    {
        Elemento novo = new Elemento();
        novo.num = valor;
        if (inicio == null) /* Se não houver elementos na lista, ele cria o primeiro, onde o início e o fim são o mesmo */
        {
            inicio = novo;
            fim = novo;
        }
        else
        {
            fim.prox = novo;// O próximo numero do Fim recebe o novo, ou seja, o próximo de fim é o novo.
            fim = novo; // o novo se torna a referência de "fim"

        }
    }
    public void Listar()
    {
        aux = inicio;
        while (aux != null) /* o aux percorre toda a lista, do inicio até o fim, já que ele recebe o inicío e vai percorrendo por .prox */
        {
            System.Console.Write($"{aux.num,5}");
            aux = aux.prox;
        }
        System.Console.WriteLine("");
    }

    public void RemoveInicio()
    {
        Console.Clear();
        if (inicio == null) /* se inicio == null, logo não há nada na lista ainda */
        {
            System.Console.WriteLine("Não há nada para remover!");
        }
        else
        {
            inicio = inicio.prox; // o início simplesmente se torna o próximo elemento da lista
        }
    }

    public void RemoveFim()
    {
        aux = inicio;

        if (inicio == fim) /* Se o fim == inicio, significa que só tem 1 elemento na lista */
        {
            inicio = null; fim = null;
        }
        else if (inicio == null) /* Se o início é null, não há elementos */
        {
            Console.Clear();
            System.Console.WriteLine("Não há elementos para serem removidos ");
        }
        else // nos outros casos, você percorre com o aux, até que ele pare no penultimo (o aux.prox apontará para o fim)
        {
            while (aux.prox != fim)
            {
                aux = aux.prox;
            }
            fim = aux; /* Como você tem o penúltimo, você faz com que ele se torne o fim e aponte para null */
            fim.prox = null;
        }
    }
}

class Program
{
    static void Main()
    {
        Lista minhaLista = new Lista();
        int resp = 0;
        int op, num;

        do
        {
            System.Console.WriteLine("1 - Inserir Inicio\n2 - Inserir Fim\n3 - Mostrar Lista\n4 - Remover Início\n5- Remover Fim\n6 - Encerrar o programa");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    System.Console.WriteLine("Insira o valor que deseja inserir");
                    num = int.Parse(Console.ReadLine());
                    minhaLista.AddInicio(num);
                    Console.Clear();
                    break;
                case 2:
                    System.Console.WriteLine("Insira o valor que deseja inserir no fim");
                    num = int.Parse(Console.ReadLine());
                    minhaLista.AddFim(num);
                    Console.Clear();
                    break;
                case 3:
                    minhaLista.Listar();
                    break;
                case 4:
                    Console.Clear();
                    minhaLista.RemoveInicio();
                    break;
                case 5:
                    Console.Clear();
                    minhaLista.RemoveFim();
                    break;
                case 6:
                    System.Console.WriteLine("Encerrando...");
                    break;

                default:
                    System.Console.WriteLine("Insira uma opção válida");
                    break;
            }
        } while (resp != 6);
    }
}