
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace View
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }
        string sql, titulo;
       
        private void MostraPesquisa(Enumerador e,string sql, string titulo)
        {
            frm_Pesquisa mostrarPesquisa = new frm_Pesquisa(e,sql,titulo);
            mostrarPesquisa.MdiParent = this;
            mostrarPesquisa.Show();
       
        }
        
         private void selecionarTodosOsPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM Orders";
            titulo = "Selecionar Todos Os Pedidos";
            MostraPesquisa(Enumerador.UM, sql, titulo);
        }

        private void selecionarONomeDeTodosOsClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT CompanyName FROM customers";
            titulo = "Selecionar o Nome De Todos Os Clientes";

            MostraPesquisa(Enumerador.DOIS, sql, titulo);
        }

      
        private void selecionarONomeDosProdutosEONomeDaRespectivaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT p.ProductName, c.CategoryName FROM products p INNER JOIN categories c ON (c.CategoryID = p.categoryID);";
            titulo = "Selecionar o Nome Dos Produtos e o Nome Da Respectiva Categoria";

            MostraPesquisa(Enumerador.TRES, sql, titulo);
        }

        private void selecionarTodosOsClientesQueComeçamComALetraAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT CompanyName FROM customers WHERE CompanyName LIKE 'a%'";
            titulo = "Selecionar Todos Os Clientes Que Começam Com a Letra ‘A’";

            MostraPesquisa(Enumerador.QUATRO, sql, titulo);
        }

        private void selecionarOsNomesSemRepetiçõesDosEmpregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT DISTINCT (a.FirstName) FROM Employees AS a";
            titulo = "Selecionar Os Nomes Sem Repetições Dos Empregados";

            MostraPesquisa(Enumerador.CINCO, sql, titulo);
        }

        private void selecioneONomeDosFornecedoresQuePossuemAColunaHomepageNulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT CompanyName, HomePage FROM suppliers WHERE HomePage is NULL";
            titulo = "Selecione o Nome Dos Fornecedores Que Possuem a Coluna Homepage Nula";

            MostraPesquisa(Enumerador.SEIS, sql, titulo);
        }

        private void selecioneONomeDosClientesQueRealizaramPedidosEntreAsDatasDe05071996E20011998ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT  c.CompanyName,o.RequiredDate FROM customers c INNER JOIN orders o on (c.customerID = o.customerID) WHERE RequiredDate BETWEEN CONVERT(date,'1996/07/05') AND CONVERT(date,'1998/01/20')";
            titulo = "Selecione o Nome Dos Clientes Que Realizaram Pedidos Entre As Datas De 05/07/1996 e 20/01/1998";

            MostraPesquisa(Enumerador.SETE, sql, titulo);
        }

        private void selecioneTodosOsEmpregadosOrdenadosPeloSobrenomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM employees ORDER BY lastName";
            titulo = "Selecione Todos Os Empregados Ordenados Pelo Sobrenome";
            MostraPesquisa(Enumerador.OITO,sql,titulo);
        }

        private void realizeUmaContagemDeQuantosProdutosOVendedorDeIdentificador4RealizouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT COUNT(*) FROM orders WHERE employeeID ='4'";
            titulo = "Realize Uma Contagem De Quantos Produtos o Vendedor De Identificador 4 Realizou";
            MostraPesquisa(Enumerador.NOVE,sql,titulo);
        }

        private void selecioneONomeDoEmpregadoEAQuantidadeDeProdutosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT e.FirstName,count(o.orderID) FROM employees e INNER JOIN orders o ON (e.employeeID = o.employeeID)";
            titulo = "Selecione o Nome Do Empregado e a Quantidade De Produtos Vendidos";
            MostraPesquisa(Enumerador.DEZ, sql, titulo);
      
        }

        private void selecioneONomeDoClienteEONomeDoEmpregadoEmUmRespectivoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "";
            titulo = "Selecione o Nome Do Cliente e o Nome Do Empregado Em Um Respectivo Pedido";
            MostraPesquisa(Enumerador.ONZE, sql, titulo);
      
        }

        private void selecioneASomaDoPreçoUnitárioDosProdutosAgrupadosPelaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "";
            titulo = "Selecione a Soma Do Preço Unitário Dos Produtos Agrupados Pela Categoria";
            MostraPesquisa(Enumerador.DOZE, sql, titulo);

        }

        private void realizeASomaDosDescontosDeTodosOsPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT Sum(o.Discount) FROM [order details] o";
            titulo = "Realize a Soma Dos Descontos De Todos Os Pedidos";
            MostraPesquisa(Enumerador.TREZE,sql, titulo);

        }

        private void realizeAContagemDeTodosOsPedidosRealizadosAgrupadosPeloClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT c.CompanyName,COUNT(*) FROM orders o inner join customers c on (o.CustomerID= c.CustomerID) group by(c.CompanyName)";
            titulo = "Realize a Contagem De Todos Os Pedidos Realizados Agrupados Pelo Cliente";
            MostraPesquisa(Enumerador.QUATORZE, sql, titulo);

        }

        private void realizeASomaDeTodosOsPedidosRealizadosAgrupadosPeloClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = "SELECT c.CompanyName,SUM(o.OrderID) FROM orders o inner join customers c on (o.CustomerID= c.CustomerID) group by(c.CompanyName)";
            titulo = "Realize a Soma De Todos Os Pedidos Realizados Agrupados Pelo Cliente";
            MostraPesquisa(Enumerador.QUINZE, sql, titulo);

        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            //this.BackgroundImageLayout = ImageLayout.None;
            //this.BackgroundImageLayout = ImageLayout.Center;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            //this.BackgroundImageLayout = ImageLayout.Tile;
            //this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
