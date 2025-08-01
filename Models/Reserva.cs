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
      // OK: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
      if (Suite.Capacidade >= hospedes.Count)
      {
        Hospedes = hospedes;
      }
      else
      {
        // OK: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
        throw new Exception("Capacidade reduzida. Escolha outra suite.");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      // OK: Retorna a quantidade de hóspedes (propriedade Hospedes)
      return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
      // TODO: Retorna o valor da diária
      // OK: DiasReservados X Suite.ValorDiaria
      decimal valor = DiasReservados * Suite.ValorDiaria;

      // OK: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
      if (DiasReservados >= 10)
      {
        valor *= 0.9M;
      }

      return valor;
    }
  }
}