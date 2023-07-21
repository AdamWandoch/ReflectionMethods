/// <summary>
/// Clase do base da todas telas onde será bem implementar ValidarAcesso
/// </summary>
class BasePage
{
    /// <summary>
    /// Para paginas que erdem do BasePage nem precisa chamar no Page_PreInit(), o construtor ja chama
    /// </summary>
    public BasePage()
    {
        //obrigatorio chamar validacao primera coisa dentro do construtor sem parametros
        ValidarAcesso();
    }

    /// <summary>
    /// Baseando na classe do chamante valida no banco o nCdFuncionalidade vinculada a tela.
    /// Tem que ficar como metodo publico para chamar no comeco de cada chamada AJAX.
    /// </summary>
    public void ValidarAcesso()
    {
        //identificar tela chamante
        var sDsClasseDaTelaChamante = GetType().Name;

        try
        {
            //identificar nCdFuncionalidade vinculada a tela para validar no banco
            var nCdFuncionalidade = (int)Enum.Parse(typeof(Tela), sDsClasseDaTelaChamante);

            //aqui tal vez if (cwBase == null) cwBase = CriarCWBase()..
            //e é so chamar new Feature().ValidateFeature(nCdFuncionalidade)

            Console.WriteLine("Classe da tela chamante: \t" + sDsClasseDaTelaChamante);
            Console.WriteLine("nCdFuncionalidade para validar: " + nCdFuncionalidade);
            Console.WriteLine();
        }
        catch (ArgumentException e)
        {
            //aqui tem que tratar caso nao tem vinculo no enum Tela 
            Console.WriteLine($"Tela \"{sDsClasseDaTelaChamante}\" nao cadastrada no enumerador ({e.Message})");
            Console.WriteLine();
        }
        catch (Exception e)
        {
            //aqui nao passou validacao
            //gente tem que loggar o erro e redirecionar para tela de ErroPermissao
            //Response.Redirect(sb.sProjeto + "Core/ErroPermissao.aspx");
            Console.WriteLine(e);
        }
    }
}
