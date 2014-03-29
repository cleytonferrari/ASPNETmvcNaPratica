using TiSelvagem.Repositorio;
using TISelvagem.RepositorioEF;

namespace TISelvagem.Aplicacao
{
    public class AlunoAplicacaoConstrutor
    {
        public static AlunoAplicacao AlunoAplicacaoADO()
        {
            return new AlunoAplicacao(new AlunoRepositorioADO());
        }

        public static AlunoAplicacao AlunoAplicacaoEF()
        {
            return new AlunoAplicacao(new AlunoRepositorioEF());
        }
    }
}
