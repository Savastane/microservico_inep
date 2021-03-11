using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.domain.documentos
{
    public class Identificacao: Notifiable<Notification>
    {


        public Identificacao( string Codigo, 
                              string Nome, 
                              string Email,
                              string Situacao, 
                              DateTime? InicioAnoLetivo,
                              DateTime? FinalAnoLetivo,
                              string CEP ,
                              string UF ,
                              string Estado ,
                              string Municipio ,
                              string Distrito ,
                              string Logradouro,
                              string Numero,
                              string Complemento,
                              string LocalizacaoGeografica,
                              string Bairro,
                              string CodigoOrgaoRegional,
                              string DescricaoOrgaoRegional,
                              string Localizacao ,
                              string LocalizacaoDiferenciada,
                              string DependenciaAdministrativa,
                              string VinculoOrgaoPublico,
                              string CategoriaEscolaPrivada,
                              string ConvenioPoderPublico,
                              string MatenedoraEscolaPrivada,
                              string CNPJMantenedora,
                              string CNPJ,
                              string Regulamentacao,
                              string EsferaAdministrativa,
                              string UnidadeVincula
            )

        {

            this.Codigo = Codigo;
            this.Nome = Nome;            
            this.Situacao = new SituacaoEscola(Situacao);
            this.PeriodoLetivo = new PeriodoLetivo("PeriodoLetivo", InicioAnoLetivo, FinalAnoLetivo, Situacao, DateTime.Now.Date);
            this.Endereco = new Endereco(CEP, UF, Estado, Municipio, Distrito, Logradouro, Numero, Complemento, LocalizacaoGeografica, Bairro);
            this.Telefone= new Telefone("62","00000000000", "Telefone");
            this.TelefoneOutroContato = new Telefone("62", "00000000000", "Contato");
            this.Email = new Email(Email);
            this.OrgaoRegional= new OrgaoRegional(CodigoOrgaoRegional, DescricaoOrgaoRegional);
            this.Localizacao = new Localizacao(Localizacao);
            this.LocalizacaoDiferenciada = new LocalizacaoDiferenciada(LocalizacaoDiferenciada, Localizacao);
            this.DependenciaAdministrativa = new DependenciaAdministrativa(DependenciaAdministrativa, Municipio);
            this.VinculoOrgaoPublico = new VinculoOrgaoPublico(VinculoOrgaoPublico,"", "", "",  DependenciaAdministrativa);
            this.CategoriaEscolaPrivada = new CategoriaEscolaPrivada(CategoriaEscolaPrivada,Situacao, DependenciaAdministrativa);
            this.ConvenioPoderPublico = new ConvenioPoderPublico(CategoriaEscolaPrivada, Situacao, DependenciaAdministrativa);



            AddNotifications(this.Email.Notifications);
            AddNotifications(this.Situacao.Notifications);
            AddNotifications(this.PeriodoLetivo.Notifications);
            AddNotifications(this.Endereco.Notifications);
            AddNotifications(this.Telefone.Notifications);
            AddNotifications(this.TelefoneOutroContato.Notifications);
            AddNotifications(this.OrgaoRegional.Notifications);
            AddNotifications(this.Localizacao.Notifications);
            AddNotifications(this.LocalizacaoDiferenciada.Notifications);
            AddNotifications(this.DependenciaAdministrativa.Notifications);
            AddNotifications(this.VinculoOrgaoPublico.Notifications); /** não validado */
            AddNotifications(this.CategoriaEscolaPrivada.Notifications);
            AddNotifications(this.ConvenioPoderPublico.Notifications);

            AddNotifications(this.OrgaoRegional.Notifications);
            AddNotifications(this.OrgaoRegional.Notifications);
            AddNotifications(this.OrgaoRegional.Notifications);
            AddNotifications(this.OrgaoRegional.Notifications);
            AddNotifications(this.OrgaoRegional.Notifications);

            AddNotifications(this.OrgaoRegional.Notifications);
        }



        public string Codigo { get; private set; }

        public string Nome { get; private set; }

        public SituacaoEscola Situacao { get; private set; }

        public PeriodoLetivo PeriodoLetivo { get; private set; }
        
        public Endereco Endereco { get; private set; }

        public Telefone Telefone { get; private set; }        

        public Telefone TelefoneOutroContato { get; private set; }

        public Email Email { get; private set; }

        public OrgaoRegional OrgaoRegional { get; private set; }

        public Localizacao Localizacao { get; private set; }

        public LocalizacaoDiferenciada LocalizacaoDiferenciada { get; private set; }

        public DependenciaAdministrativa DependenciaAdministrativa { get; private set; }

        public VinculoOrgaoPublico VinculoOrgaoPublico { get; private set; }

        public CategoriaEscolaPrivada CategoriaEscolaPrivada { get; private set; }

        public ConvenioPoderPublico ConvenioPoderPublico { get; private set; }

     //   public MatenedoraEscolaPrivada MatenedoraEscolaPrivada { get; private set; }

        public CNPJ CNPJMantenedora { get; private set; }
        /// <summary>
        /// CNPJ Escola Privada
        /// </summary>
        public CNPJ CNPJ { get; private set; }

        /// <summary>
        /// – Regulamentação/autorização no conselho ou órgão municipal, estadual ou federal de educação
        /// </summary>
        public string Regulamentacao { get; private set; }

        /// <summary>
        /// – – Esfera administrativa do conselho ou órgão responsável pela regulamentação/autorização
        /// </summary>
        public EsferaAdministrativa EsferaAdministrativa { get; private set; }

        public UnidadeVincula UnidadeVincula { get; private set; }
    }
}
