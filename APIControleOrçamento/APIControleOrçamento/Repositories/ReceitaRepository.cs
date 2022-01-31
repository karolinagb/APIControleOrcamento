using APIControleOrçamento.Data;
using APIControleOrçamento.Models;
using System;
using System.Linq;

namespace APIControleOrçamento.Repositories
{
    public class ReceitaRepository : Repository<Receita>
    {
        public ReceitaRepository(APIControleOrcamentoContext context) : base(context) { }

        public bool BeUnique(Receita model)
        {
            var dia = DateTime.DaysInMonth(model.Data.Year, model.Data.Month);

            var dataFinal = new DateTime(model.Data.Year, model.Data.Month, dia);
            var dataInicial = new DateTime(model.Data.Year, model.Data.Month, 1);

            var result = _context.Receitas.Where(x=> x.Data.Date >= dataInicial.Date && x.Data.Date <= dataFinal.Date)
                .Where(x => x.Descricao == model.Descricao).Count();

            if(result == 0)
            {
                return true;
            }

            return false;
        }
    }
}
