using inep.domain.entities;
using inep.domain.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.repository.Repository
{
    public class EscolaRepository 
    {
        private Context context;

        public EscolaRepository(Context context)
        {
            this.context = context;
        }

        

        public async Task<EscolaEntity> GetById(long id)
        {
            return await context.Escola.FindAsync(id);
        }

        public async Task<IEnumerable<EscolaEntity>> GetEscolas()
        {
            
            return await context.Escola.ToListAsync();
            
            
        }


        public void Add(EscolaEntity escola)
        {
            context.Escola.Add(escola);
            context.SaveChanges();
        }


        public void Remove(EscolaEntity escola)
        {
            context.Escola.Remove(escola);
            context.SaveChanges();
        }

        public void Update(EscolaEntity escola)
        {
            context.Escola.Update(escola);
            context.SaveChanges();
        }
    }
}
