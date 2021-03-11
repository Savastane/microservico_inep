using inep.domain.documentos;
using inep.domain.interfaces;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client.Documents;

namespace inep.repository.raven
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly IAsyncDocumentSession session;

        public EscolaRepository()
        {
            
        }

        public EscolaRepository(IAsyncDocumentSession dbSession)
        {
            this.session = dbSession;
        }

        
        public Task<Escola> GetById(string codigo)
        {   
                return session.LoadAsync<Escola>("escolas/"+codigo);
        }

        public Task<List<Escola>> GetEscolas()
        {

            return session.Query<Escola>()
                   .OrderBy(x => x.Identificacao.Codigo)
                   .ToListAsync();
        
        }

        public Task<Escola> Add(Escola escola)
        {
            
                session.StoreAsync(escola);
                session.SaveChangesAsync();

                return Task.FromResult(escola);
            
        }

        public void Remove(Escola escola)
        {
            
                session.Delete(escola.GetType() + "/" + escola.Identificacao.Codigo);
                session.SaveChangesAsync();

                
        }

        public Task<Escola> Update(Escola escola)
        {
            
                session.StoreAsync(escola);
                session.SaveChangesAsync();

            return Task.FromResult(escola);
        }

        public void UpdateIdentificacao(string id, Identificacao identificacao)
        {

            session.Advanced.Patch<Escola, Identificacao>(
                           $"escolas/{id}" ,
                           x => x.Identificacao, identificacao);

            session.SaveChangesAsync();
            






            



        }


      

        

        //public void Backup()
        //{
        //    var temp = $"http://localhost:8080{Guid.NewGuid()}";
        //    Directory.CreateDirectory(temp);
        //    Contexto.Store
        //            .DatabaseCommands
        //            .GlobalAdmin
        //            .StartBackup(temp, new DatabaseDocument(), incremental: false, databaseName: "INEP")
        //            .WaitForCompletion();

        //    var dir = $"http://localhost:8080{ DateTime.Now.ToString("yyyy/MM/dd/")}";
        //    var arquivoZip = $"{dir}{ DateTime.Now.ToString("HH-mm-ss")}.zip";
        //    Directory.CreateDirectory(dir);
        //    ZipFile.CreateFromDirectory(temp, arquivoZip);
        //    Directory.Delete(temp, true);
        //}
    }
}
