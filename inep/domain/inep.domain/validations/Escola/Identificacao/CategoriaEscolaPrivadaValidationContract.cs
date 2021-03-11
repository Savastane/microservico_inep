using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;


namespace inep.domain.valueobject.Validations
{
    internal class CategoriaEscolaPrivadaValidationContract : Contract<CategoriaEscolaPrivada>
    {
        public CategoriaEscolaPrivadaValidationContract(CategoriaEscolaPrivada categoria)
        {

            if ((categoria.Situacao == "1") && (categoria.DependenciaAdministrativa =="4"))
            {
                long? codigo = Convert.ToInt64(String.IsNullOrEmpty(categoria.Codigo) ? null : Convert.ToInt64(categoria.Codigo));

                Requires()
                    .IsNotNullOrEmpty(categoria.Codigo, "CategoriaEscolaPrivada", "Quando Situação 1 Categoria é obrigatoria")
                    .IsBetween(codigo ?? 0, 1, 4, "CategoriaEscolaPrivada", "Somente aceita os seguintes caracteres entre parêntesis: (1 2 3 4). Legenda:  1 – particular  2 – comunitária  3 – confessional  4 – filantrópica");

                /*
                 * 
                 * Deve ser preenchido quando o campo 3 (Situação de funcionamento) for preenchido com 1 (Em atividade) e o campo 21 (Dependência administrativa) for preenchido com 4 (privada).
                 * */
            }
            else
            {
                Requires()
                .IsNullOrEmpty(categoria.Codigo, "CategoriaEscolaPrivada", "Campo não pode ser preenchido");
                
            }

                
            
        }
    }

    
    
}
