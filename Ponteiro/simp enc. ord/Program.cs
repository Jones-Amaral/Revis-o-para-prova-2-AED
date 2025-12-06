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
    private Elemento ant;
    public Lista()
    {
        inicio = null; fim = null;
    }

    public void Inserir(int valor)
    {
        Elemento novo = new Elemento();
        novo.num = valor;

        if (inicio == null) /* Lista vazia */
        {
            inicio = novo;
            fim = novo;
            return;
        }

        aux = inicio;

        if (valor < aux.num) /* Primeiro Elemento da lista já é maior do que o valor a inserir */
        {
            novo.prox = inicio;
            inicio = novo;
            return;
        }

        while (aux != null && aux.num < valor) /* Enquanto o aux não for null, ou seja, ele percorreu tudo e não achou, ou se achar o valor */
        {
            ant = aux;
            aux = aux.prox;
        }

        if (aux == null) /* Percorreu toda a lista e não achou um numero maior que "valor" */
        {
            fim.prox = novo;
            fim = novo;
        }
        else/* Insere no meio de dois valores, porque o valor de aux é maior que o número, então ele deve ser inserido entre ant e aux */
        {
            ant.prox = novo;
            novo.prox = aux;
        }

    }
    public void Remove(int valor)
    {
        if (inicio == null) /* Não há elementos na lista */
        {
            System.Console.WriteLine("Não há elementos na lista");
            return;
        }

        // Ponteiros para o while
        aux = inicio;
        ant = null;

        while (aux != null && aux.num != valor) /* Se o aux se tornar null, o elemento não foi encontrado, se o valor bater, achamos o elemento */
        {
            ant = aux;
            aux = aux.prox;
        }

        if (aux == null) /* Percorreu tudo e não encontrou */
        {
            System.Console.WriteLine("Elemento não encontrado");
            return;
        }

        if (ant == null) /* O primeiro elemento já é o correto */
        {
            inicio = inicio.prox;

            if (inicio == null) /* Nesse caso, o inicio se tornou null, havia apenas 1 elemento */
            {
                fim = null; //Então o fim também deve ser null.
            }
            return;
        }
        else
        {
            ant.prox = aux.prox; /* O valor foi encontrado em algum elemento */
            if (aux == fim) /* Esse elemento é o último, então o ant == penultimo, logo, o ant deve se tornar o fim. */
            {
                fim = ant;
                ant.prox = null;
            }
        }
    }
}