using Web_Aulas.Interface;

namespace Web_Aulas.Models
{
    public class Pessoa : IPessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }    
        public string SobreNome { get; set; }

        public Pessoa()
        {
            Id = new Guid();
            Nome = "Pedro";
            SobreNome = "Mateus";
            Andar();
            Correr();
            Pular();
        }

        public string Andar()
        {
            return "Andando";
        }

        public string Correr()
        {
            return "Correndo";
        }

        public string Pular()
        {
            return "Pulando";
        }

        public void Comer()
        {
            int Paes = 10;
        }
    }
}
