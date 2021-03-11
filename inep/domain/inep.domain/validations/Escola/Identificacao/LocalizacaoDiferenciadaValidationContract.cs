using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class LocalizacaoDiferenciadaValidationContract : Contract<LocalizacaoDiferenciada>
    {
        public LocalizacaoDiferenciadaValidationContract(LocalizacaoDiferenciada localizacao)
        {
            long permitidos = Convert.ToInt64(String.IsNullOrEmpty(localizacao.Codigo) ? 0 : Convert.ToInt64(localizacao.Codigo));



            var requerido = Requires()
                .IsNotNullOrEmpty(localizacao.Codigo, "LocalizacaoDiferenciada", "Localizaca oDiferenciada não pode ser vazio nem nulo")
                .Contains(permitidos, new long[] { 1, 2, 3, 7 }, "LocalizacaoDiferenciada", "os valores permitidos são  1 – Área de assentamento 2 – Terra indígena 3 – Área onde se localiza comunidade remanescente de quilombos  7 – Não está em área de localização diferenciada");

            if (localizacao.CodigoLocalizacao == "1")
            {
                requerido.AreNotEquals(localizacao.Codigo, "1", "LocalizacaoDiferenciada", "Não pode ser preenchido com 1 (Área de assentamento) quando o campo 19 (Localização/Zona da escola) for preenchido com 1 (urbana).");
            }
                
                

        }
    }

    
    
}
