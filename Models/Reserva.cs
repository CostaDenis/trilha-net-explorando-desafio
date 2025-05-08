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
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                //Exeception caso a quantidade de hóspedes exceda a capacidade da suíte
                throw new Exception("A capacidade de hóspedes não pode exceder a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%

            decimal desconto = (DiasReservados >= 10) ? desconto = 0.1m : desconto = 0;
            return (DiasReservados * Suite.ValorDiaria) - (DiasReservados * Suite.ValorDiaria * desconto);
        }
    }
}