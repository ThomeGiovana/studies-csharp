namespace CSharpCourse.Fundamentos {
    internal class Inferencia {
        public static void Execute() {
            // É necessário inicializar a variável para ter inferência de tipo
            var nome = "Jane Doe"; 
            Console.WriteLine($"C# pode fazer a inferência de um tipo a partir do valor que é passado para a variável:");
            Console.WriteLine($"Variável: {nameof(nome)}");
            Console.WriteLine($"Tipo: {nome.GetType()}");
        }
    }
}
