namespace CSharpCourse.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Execute() {
            // circle area
            double raio = 4.5;
            const double pi = 3.14;

            double area = pi * raio * raio;
            Console.WriteLine($"A área é {area}");
            Console.WriteLine("A área não é " + (area + 1000));

            /*
             * byte - 1 byte
             * short - 2 bytes
             * int - 4 bytes
             * long - 8 bytes
             */

            // Valores inteiros
            Console.WriteLine($"====== Valores inteiros ======");
            byte idade = 45; // aceita apenas valores positivos
            Console.WriteLine($"Idade: {idade}");
            sbyte saldaFinanceiro = -45;// aceita valores negativos
            Console.WriteLine($"Saldo: {saldaFinanceiro}");
            Console.WriteLine($"Menor valor de um inteiro: {int.MinValue}");
            uint valorSemSinal = 30; // não assume valores negativos
            Console.WriteLine($"Variável de tipo {nameof(UInt128)} não aceita valores negativos: {valorSemSinal}");
            uint populacaoAleatoria = 600_000_000;
            Console.WriteLine($"Uso de underscore não interfere no número {populacaoAleatoria}");
            int milisegundos = 1000_000;
            Console.WriteLine($"Outro exemplo: 1000_000 em print: 1000_000 {milisegundos}");
            ulong populacao = 7_600_000_000;
            Console.WriteLine($"Exemplo de long sem sinal: {populacao}");

            // Valores de ponto flutuante
            Console.WriteLine($"====== Valores de ponto flutuante ======");
            float precoComputador = 40000.99f; // não podemos armazenar double dentro de float
            double pontoFlutuanteGrande = 40000000000000000.999; // double armezena o dobro de float
            decimal maxDecimal = decimal.MaxValue;
            Console.WriteLine($"Valores máximos de float, double e decima, respectivamente: \n {float.MaxValue}, {double.MaxValue} e {maxDecimal}");
        }
    }
}
