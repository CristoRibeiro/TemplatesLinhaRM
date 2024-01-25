using ScaffoldingRM.GeradorNegocio.DTO;

namespace ScaffoldingRM.GeradorNegocio.Interface
{
  public interface IFactoryCodigoFonte
  {
    ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase);
  }
}
