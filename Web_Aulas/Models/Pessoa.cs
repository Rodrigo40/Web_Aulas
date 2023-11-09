namespace Web_Aulas.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }    
        public string SobreNome { get; set; }

        public Pessoa()
        {
            Id = new Guid();
            Nome = "Pedro";
            SobreNome = "Mateus";
        }
    }
}
