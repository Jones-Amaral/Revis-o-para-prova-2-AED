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
            novo.prox = inicio; /* O próximo do novo vira o início */
            inicio.anterior = novo; /* o anterior do antigo inicio aponta para o novo*/
            inicio = novo; /* o novo vira o início */
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
            novo.anterior = fim; /* liga o novo ao fim */
            fim.prox = novo; /* liga o fim ao novo */
            novo.prox = null; /* o fim não aponta para nada */
            fim = novo; /* o novo se torna o fim */
        }
    }
    public void MostraLista()
    {
        while (aux != null)
        {
            System.Console.WriteLine($"{aux.num}\t");
            aux = aux.prox;
        }
    }

}
class Program
{
    static void Main()
    {

    }
}