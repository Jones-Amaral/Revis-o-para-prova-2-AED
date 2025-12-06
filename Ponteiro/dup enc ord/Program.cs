using System.Formats.Asn1;

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
    public void Inserir(int valor)
    {
        Elemento novo = new Elemento();
        novo.num = valor;

        if (inicio == null) /* Se não houver Elementos, ele cria o novo como o primeiro da lsita */
        {
            inicio = novo;
            fim = novo;
            return;
        }

        // variáveis condicionais para o while
        ant = null;
        aux = inicio;

        while (aux != null && aux.num < valor)
        {
            ant = aux;
            aux = aux.prox;
        }

        if (ant == null) /* caso o primeiro elemento já seja maior que o valor que desejamos inserir */
        {
            novo.prox = inicio;
            inicio.anterior = novo;
            inicio = novo;
        }
        else if (aux == null) /* Caso percorra a fila toda e não encontre um valor maior que o que desejamos inserir */
        {
            fim.prox = novo;
            novo.anterior = fim;
            novo.prox = null;
            fim = novo;
        }
        else /* Caso encontre um número maior do que o que desejamos inserir, então o "valor" será inserido entre ant e aux*/
        {
            ant.prox = novo;
            aux.anterior = novo;
            novo.anterior = ant;
            novo.prox = aux;
        }
    }
    public void Remover(int valor)
    {
        if (inicio == null) // Verifica se a lista está populada
        {
            System.Console.WriteLine("Não há elementos para remover");
            return;
        }

        // variáveis condicionais para utilizar o while
        ant = null;
        aux = inicio;

        while (aux != null && aux.num != valor)
        {
            ant = aux;
            aux = aux.prox;
        }

        if (aux == null) // percorreu toda a lista e não encontrou
        {
            System.Console.WriteLine("Elemento não encontrado");
            return;
        }
        /* ant == null já resolve para listas com apenas 1 elemento, ou se o primeiro elemento já é o desejado */
        if (ant == null) // Se ant == null, o primeiro valor já é o que desejamos remover, logo, o inicio deve se tornar o segundo valor
        {
            inicio = inicio.prox;
            
            if (inicio == null) /* Se o início se tornou null, o fim também deve ser null, pois a lista está vazia */
                fim = null;
            else
                inicio.anterior = null; /* se o início não é null, o inicio agora é algum valor, logo, não deve possuir anterior */
        }
        else
        {
            // o elemento anterior aponta para depois do aux, eliminando o aux
            ant.prox = aux.prox;

            if (aux == fim) // Se o aux for o último elemento, deve haver um tratamento especial, o ant deve se tornar o fim
            {
                fim = ant;
                fim.prox = null;
            }
            else
            {
                aux.prox.anterior = ant;
                /* o anterior do próximo número de aux, irá receber o anterior de aux, ex:
                3, 6, 10, 13 -> Desejamos remover o 10, 
                6 = ant
                10 = aux
                o anterior do próximo número (anterior do 13), será o ant (6)
                 */
            }
        }

    }
}