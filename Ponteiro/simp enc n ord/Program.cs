using System.Security.Principal;

class Elemento
{
    public int num;
    public Elemento prox;
}
class Lista
{
    private Elemento inicio;
    private Elemento fim;
    private Elemento aux;
    public Lista()
    {
        inicio = null;
        fim = null;
    }
    public void InserirInicio(int valor)
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
        }
        else
        {
            fim.prox = novo;
            fim = novo;
        }
    }
    public void RemoveInicio()
    {
        if (inicio == null)
        {
            System.Console.WriteLine("Não há elementos para removerç");
            return;
        }
        if (inicio == fim)
        {
            inicio = null;
            fim = null;
        }
        else
        {
            inicio = inicio.prox;
        }
    }
    public void RemoveFim()
    {
        if (inicio == null)
        {
            System.Console.WriteLine("Não há elementos para removerç");
            return;
        }
        if (inicio == fim)
        {
            inicio = null;
            fim = null;
        }
        else
        {
            aux = inicio;
            while (aux.prox != fim)
            {
                aux = aux.prox;
            }
            aux.prox = null;
        }
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