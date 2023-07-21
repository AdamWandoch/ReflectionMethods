﻿Console.WriteLine("test start");
Console.WriteLine();

new BasePage();

new BasePageComprador(12);

new OrdemCompraPesquisa();

new OrdemCompraManutencao();

new CotacaoPesquisa(123);

Console.WriteLine("test end");
Console.ReadLine();

/// <summary>
/// Simulacao das classes que erdem do BasePage
/// </summary>
#region Classes Derivadas

class BasePageComprador : BasePage
{
    public BasePageComprador() { }
    public BasePageComprador(int nValor)
    {
        Console.WriteLine("Logica do BasePageComprador - exemplo, valor do parametro: " + nValor);
        Console.WriteLine();
    }
}

class OrdemCompraPesquisa : BasePageComprador
{
    public OrdemCompraPesquisa() { }
}

class OrdemCompraManutencao : OrdemCompraPesquisa
{
    public OrdemCompraManutencao() { }
}

class CotacaoPesquisa : BasePage
{
    public CotacaoPesquisa(int a) { }
}

#endregion

/// <summary>
/// Mapeamento do nome da classe da tela com nCdFuncionalidade do nCdMenuPai utilizado para accesso ao tela.
/// Unico lugar onde vinculamos a funcionalidade com a tela que erde do BasePage.
/// Assim é possivel utilizar o mesmo nCdFuncionalidade para controlar acesso ao varias telas relacionadas.
/// </summary>
enum Tela
{
    BasePage = 24,
    BasePageComprador = 543,
    OrdemCompraPesquisa = 234,
    OrdemCompraManutencao = 111,
    CotacaoPesquisa = 222,
}