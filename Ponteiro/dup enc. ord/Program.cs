using System.Collections.Generic;

class Elemento
{
    public int num;
    public Elemento prox;
    public Elemento anterior;
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
        ant = null;
    }
    public void Inserir(int valor)
    {
        Elemento novo = new Elemento();
        novo.num = valor;
        if (inicio == null) /* Cria no inicio */
        {
            inicio = novo;
            fim = novo;
        }
        else if (valor < inicio.num) /* Insere no inicio */
        {
            novo.prox = inicio;
            inicio.anterior = novo;
            inicio = novo;
        }
        else
        {
            aux = inicio;
            while (aux != null && aux.num < novo.num)
            {
                ant = aux;
                aux = aux.prox;
            }
            if (aux == null) /* Insere no fim */
            {
                fim.prox = novo;
                novo.anterior = fim;
                fim = novo;
            }
            else /* Insere no meio */
            {
                novo.anterior = ant;
                ant.prox = novo;
                novo.prox = aux;
                aux.anterior = novo;
            }
        }

    }
    public void Remover(int valor)
    {
        if (inicio == null)
        {
            System.Console.WriteLine("Lista vazia");
            return;
        }

        aux = inicio;

        while (aux != null && aux.num != valor)
        {
            ant = aux;
            aux = aux.prox;
        }

        if (aux == null)
        {
            System.Console.WriteLine("Elemento não encontrado para remoção");
            return;
        }

        if (aux == inicio) /* Remove o primeiro */
        {
            inicio = inicio.prox;
            if (inicio == null) /* Se inicio se tornou null, não há mais elementos, então o fim é null */
            {
                fim = null;
            }
            else /* Se há mais elementos, o inicio.anterior do próximo elemento que substituirá o inicio, deve ser null */
            {
                inicio.anterior = null;
            }
            return;
        }

        if (aux == fim)
        {
            fim = ant;
            fim.prox = null;
            return;
        }
        ant.prox = aux.prox;
        aux.prox.anterior = ant;
    }
    public void MostraLista()
    {
        aux = inicio;
        while (aux != null)
        {
            System.Console.Write($"{aux.num,5}");
            aux = aux.prox;
        }
    }
}
class Program
{
    static int Menu()
    {
        System.Console.WriteLine("1)Inserir\n2)Remover\n3)Mostrar\n0)Encerrar");
        int resp = int.Parse(Console.ReadLine());
        return resp;
    }
    static void Main()
    {
        Lista minhaLista = new Lista();
        int valor, resp;

        do
        {
            switch (resp = Menu())
            {
                case 1:
                    System.Console.WriteLine("Insira um valor para adicionar");
                    minhaLista.Inserir(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    System.Console.WriteLine("Insira um valor para remover");
                    minhaLista.Remover(int.Parse(Console.ReadLine()));
                    break;
                case 3:
                    minhaLista.MostraLista();
                    break;
                case 0:
                    System.Console.WriteLine("Encerrando programa...");
                    break;
                default:
                    System.Console.WriteLine("Escolha uma opção válida");
                    break;
            }
        } while (resp != 0);
    }
}