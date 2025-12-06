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
            inicio.anterior = novo;
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
            novo.anterior = fim;
            fim.prox = novo;
            fim = novo;
        }
    }
    public void RemoveInicio()
    {
        if (inicio == null)
        {
            System.Console.WriteLine("Não há elemento para remover");
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
            inicio.anterior = null;
        }
    }
    public void RemoveFim()
    {
        if (inicio == null)
        {
            System.Console.WriteLine("Não há elemento para remover");
            return;
        }
        if (inicio == fim)
        {
            inicio = null;
            fim = null;
        }
        else
        {
            fim = fim.anterior;
            fim.prox = null;
        }
    }
}