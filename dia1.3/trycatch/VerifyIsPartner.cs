using System;

class Program1
{
    static void Main1(string[] args)
    {
        string taxToVerify = "123456789";

        try
        {
            bool isPartner = VerifyIsPartner(taxToVerify);
            Console.WriteLine("É parceiro: " + isPartner);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }
    }

    public static bool VerifyIsPartner(string tax)
    {
        try
        {
            var partner = new PartnershipRepository().GetPartnerByTax(tax);

            if (partner == null)
            {
                throw new NullReferenceException("Parceria não encontrada!");
            }
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }

        return true;
    }
}

class PartnershipRepository
{
    public Partner GetPartnerByTax(string tax)
    {
        // Simulação: substitua com a lógica real de busca no repositório
        return null;
    }
}

class Partner
{
    // Propriedades do parceiro
}
