namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int cap = Suite.Capacidade;
            int conte = hospedes.Count();
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("A Suite não tem capacidade para a solicitação de reservas!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados*Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor -= (valor * 10)/100;
            }

            return valor;
        }
    }
}