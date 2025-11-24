class Elemento
{
    public int num;
    public Elemento prox;
    public Elemento anterior;
}
class Lista
{
    public Lista()
    {
        inicio = null;
        fim = null;
    }
    private Elemento inicio;
    private Elemento fim;
    private Elemento aux;
    private Elemento ant;

    public void Inserir(int valor)
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
            aux = inicio;
            anterior = null;
            while (aux != null && novo.num > aux.num) /* aux para último, novo > aux para primeiro */
            {
                anterior = aux;
                aux = aux.prox;
            }

            if (anterior == null) // o primeiro número já é menor do que o que será inserido
            {
                fim.prox = novo;
                fim = novo;
                fim.prox; null;
            }
            else if (aux == null) /* Se ele for o último número, já que o aux terminou como null */
            {
                fim.prox = null;
                novo.anterior = fim;
            }
            else /* No while, satifez os critérios e achamos o número que será inserido após, ex: temos que inserir o 18, e paramos entre o ant = 15 e aux = 20 */
            {
                anterior.prox = novo;
                novo.prox = aux;
            }
        }
    }
    public void MostraLista()
    {
        Console.Clear();
        aux = inicio;
        while (aux != null)
        {
            System.Console.WriteLine($"{aux.num,7}");
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