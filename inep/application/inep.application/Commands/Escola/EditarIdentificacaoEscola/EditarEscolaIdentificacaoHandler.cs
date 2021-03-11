using Flunt.Notifications;
using inep.domain;
using inep.domain.documentos;
using inep.domain.interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inep.application.Commands
{
    public class EditarEscolaIdentificacaoHandler :  IRequestHandler<EditarEscolaIdentificacaoRequest, EditarEscolaIdentificacaoResponse>
    {
        private readonly IEscolaRepository _escolaRepository;
        public EditarEscolaIdentificacaoHandler(IEscolaRepository repository)
        {
            _escolaRepository = repository;
        }

        public  Task<EditarEscolaIdentificacaoResponse> Handle(EditarEscolaIdentificacaoRequest request, CancellationToken cancellationToken)
        {

            //var EscolaDocument = _escolaRepository.GetById(request.Id).Result;
            //EscolaDocument.SetIdentificacao(request.Id, new Identificacao(request.Codigo, request.Nome, request.Email, request.Situacao, DateTime.Now.Date, DateTime.Now.Date));

            var identificacao = new Identificacao(
                request.Codigo,
                request.Nome,
                request.Email,
                request.Situacao,
                DateTime.Now.Date,
                DateTime.Now.Date,
                request.CEP,
                request.UF,
                request.Estado,
                request.Municipio,
                request.Distrito,
                request.Logradouro,
                request.Numero,
                request.Complemento,
                request.LocalizacaoGeografica,
                request.Bairro,
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                    "",
                ""
                );



            //"41334140",
            //    "BA",
            //    "Salvador",
            //    "0000007",
            //    "0000007",
            //    "caminho 07, casa 02, quadra 03",
            //    "02",
            //    "regional",
            //    "-110000-111211",
            //    "Cajazeiras");

            var IdentificacaoResponse = new EditarEscolaIdentificacaoResponse
            {
                //Notifications = EscolaDocument.Notifications
                Notifications = identificacao.Notifications
            };

            //if (EscolaDocument.IsValid)
            if (identificacao.IsValid)       
            {

                 _escolaRepository.UpdateIdentificacao(request.Id, identificacao);
                IdentificacaoResponse.Codigo = identificacao.Codigo;                
                IdentificacaoResponse.Nome = identificacao.Nome;
                IdentificacaoResponse.Situacao= identificacao.Situacao.Codigo;
                
            }
            
            

            return Task.FromResult(IdentificacaoResponse);
             

        }


    }
}
