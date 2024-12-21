namespace CursoCSharp {
    using CSharpCourse.Fundamentos;

    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Fundamentos - Primeiro programa", PrimeiroPrograma.Execute},
                {"Fundamentos - Comentários", Comentarios.Execute},
                {"Fundamentos - Variáveis e constantes", VariaveisEConstantes.Execute},
                {"Inferência - Variáveis e constantes", Inferencia.Execute},
            });

            central.SelecionarEExecutar();
        }
    }
}