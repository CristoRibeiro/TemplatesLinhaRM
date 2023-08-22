namespace ScaffoldingRM.GeradorNegocio.Extensions
{

  public static class StringExtension
  {
    public static string ToCamelCase(this string str)
    {
      if (string.IsNullOrEmpty(str))
      {
        return str;
      }
      var strFormatada = char.ToLower(str[0]).ToString();

      if (str.Length > 1)
        strFormatada += str.Substring(1);

      return strFormatada;
    }
  }
}

