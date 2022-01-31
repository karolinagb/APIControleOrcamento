using APIControleOrçamento.Repositories;
using FluentValidation;

namespace APIControleOrçamento.Models.ViewModelValidators
{
    public class ReceitaViewModelValidator : AbstractValidator<Receita>
    {
        private readonly ReceitaRepository _receitaRepository;
        public ReceitaViewModelValidator(ReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("Descrição é obrigatório");
            RuleFor(x => x.Valor)
               .NotEmpty().WithMessage("Valor é obrigatório");
            RuleFor(x => x.Data)
               .NotEmpty().WithMessage("Data é obrigatório");
            RuleFor(x => x).Must(BeUnique).WithMessage("Já existe uma receita com essa descrição nesse mês");
        }

        public bool BeUnique(Receita model)
        {
            var result = _receitaRepository.BeUnique(model);

            return result;
        }
    }

  
}
