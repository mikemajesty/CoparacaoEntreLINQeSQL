using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frm_Pesquisa : Form
    {
        Enumerador enumerador = new Enumerador();
        NorthwindBanco banco = new NorthwindBanco();

        public frm_Pesquisa(Enumerador numero, string sql, string titulo)
        {
            InitializeComponent();

            enumerador = numero;

            if (enumerador.Equals(Enumerador.UM))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from t in banco.Orders
                                           select new
                                           {
                                               t.OrderID,
                                               t.CustomerID,
                                               t.EmployeeID,
                                               t.OrderDate,
                                               t.RequiredDate,
                                               t.ShippedDate,
                                               t.ShipVia,
                                               t.Freight,
                                               t.ShipName,
                                               t.ShipAddress,
                                               t.ShipCity,
                                               t.ShipRegion,
                                               t.ShipPostalCode,
                                               t.ShipCountry
                                           }).ToList();
            }
            if (enumerador.Equals(Enumerador.DOIS))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from t in banco.Customers
                                           select new
                                           {
                                               t.CompanyName
                                           }).ToList();

            }
            if (enumerador.Equals(Enumerador.TRES))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from p in banco.Products
                                           select new
                                           {
                                               p.ProductName,
                                               p.Categories.CategoryName
                                           }).ToList();

            }
            if (enumerador.Equals(Enumerador.QUATRO))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from Customers in banco.Customers
                                           where
                                             Customers.CompanyName.StartsWith("a")
                                           select new
                                           {
                                               Customers.CompanyName
                                           }).ToList();




            }
            if (enumerador.Equals(Enumerador.CINCO))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from a in banco.Employees
                                           select new
                                           {
                                               a.FirstName
                                           }).Distinct().ToList();


            }
            if (enumerador.Equals(Enumerador.SEIS))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from Suppliers in banco.Suppliers
                                           where
                                             Suppliers.HomePage == null
                                           select new
                                           {
                                               Suppliers.CompanyName,
                                               Suppliers.HomePage
                                           }).ToList();

            }
            if (enumerador.Equals(Enumerador.SETE))
            {
                DateTime inicio = new DateTime(1996, 07, 05);
                DateTime final = new DateTime(1998, 01, 20);

                sql = "SELECT  c.CompanyName,o.RequiredDate FROM customers c INNER JOIN orders o ON (c.customerID = o.customerID)";

                string a = "WHERE RequiredDate BETWEEN CONVERT(date,'1996/07/05') AND CONVERT(date,'1998/01/20')";

                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                ltb_SQL.Items.Add(a);

                dgv_Pesquisa.DataSource = (from o in banco.Orders
                                           where
                                             o.RequiredDate >= inicio && o.RequiredDate <= final
                                           select new
                                           {
                                               o.Customers.CompanyName,
                                               o.RequiredDate
                                           }).ToList();

            }
            if (enumerador.Equals(Enumerador.OITO))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);

                dgv_Pesquisa.DataSource = (from Employees in banco.Employees
                                           orderby
                                             Employees.LastName
                                           select new
                                           {
                                               EmployeeID = Employees.EmployeeID,
                                               LastName = Employees.LastName,
                                               FirstName = Employees.FirstName,
                                               Title = Employees.Title,
                                               TitleOfCourtesy = Employees.TitleOfCourtesy,
                                               BirthDate = Employees.BirthDate,
                                               HireDate = Employees.HireDate,
                                               Address = Employees.Address,
                                               City = Employees.City,
                                               Region = Employees.Region,
                                               PostalCode = Employees.PostalCode,
                                               Country = Employees.Country,
                                               HomePhone = Employees.HomePhone,
                                               Extension = Employees.Extension,
                                               Photo = Employees.Photo,
                                               Notes = Employees.Notes,
                                               ReportsTo = Employees.ReportsTo,
                                               PhotoPath = Employees.PhotoPath
                                           }).ToList();



            }
            if (enumerador.Equals(Enumerador.NOVE))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from Orders in
                                               (from Orders in banco.Orders
                                                where
                                                  Orders.EmployeeID == 4
                                                select new
                                                {
                                                    Dummy = "x"
                                                })
                                           group Orders by new { Orders.Dummy } into g
                                           select new
                                           {
                                               Pedidos = g.Count()
                                           }).ToList();

            }
            if (enumerador.Equals(Enumerador.DEZ))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from o in banco.Orders
                                          group new { o.Employees, o } by new
                                          {
                                              o.Employees.FirstName

                                          } into g
                                          select new
                                          {
                                              g.Key.FirstName,
                                              Quantidade = g.Count(p => p.o.OrderID != null)
                                          }).ToList();
            }
            if (enumerador.Equals(Enumerador.ONZE))
            {
                string um, dois;
                um = "SELECT o.OrderID,c.CompanyName,e.FirstName FROM orders o inner join customers c on (o.CustomerID = c.CustomerID) inner join";
                dois = "employees e on(o.EmployeeID = e.EmployeeID)  where o.OrderID='10249'";
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(um);
                ltb_SQL.Items.Add(dois);
                dgv_Pesquisa.DataSource = (from o in banco.Orders
                                          where
                                            o.OrderID == 10249
                                          select new
                                          {
                                              o.OrderID,
                                              o.Customers.CompanyName,
                                              o.Employees.FirstName
                                          }).ToList();

   
            }
            if (enumerador.Equals(Enumerador.DOZE))
            {
                txt_Titulo.Text = titulo;
                string um, dois;
                um = "Select c.CategoryName, sum(p.UnitPrice) from Categories c inner join products p";
                dois = "on (c.CategoryID=p.CategoryID) group by c.CategoryName";
                ltb_SQL.Items.Add(um);
                ltb_SQL.Items.Add(dois);
                dgv_Pesquisa.DataSource = (from p in banco.Products
                                          group new { p.Categories, p } by new
                                          {
                                              p.Categories.CategoryName
                                          } into g
                                          select new
                                          {
                                              g.Key.CategoryName,
                                              Preço = (decimal?)g.Sum(p => p.p.UnitPrice)
                                          }).ToList();

            }
             if (enumerador.Equals(Enumerador.TREZE))
            {
                txt_Titulo.Text = titulo;
                ltb_SQL.Items.Add(sql);
                dgv_Pesquisa.DataSource = (from o in
                                              (from o in banco.Order_Details
                                               select new
                                               {
                                                   o.Discount,
                                                   Dummy = "x"
                                               })
                                          group o by new { o.Dummy } into g
                                          select new
                                          {
                                              Desconto = g.Sum(p => p.Discount)
                                          }).ToList();


                }
             if (enumerador.Equals(Enumerador.QUATORZE))
             {
                 txt_Titulo.Text = titulo;
                 ltb_SQL.Items.Add(sql);
                 dgv_Pesquisa.DataSource = (from o in banco.Orders
                                           group o by new
                                           {
                                               o.Customers.CompanyName
                                           } into g
                                           select new
                                           {
                                               g.Key.CompanyName,
                                               Quantidade = g.Count()
                                           }).ToList();


             }
             if (enumerador.Equals(Enumerador.QUATORZE))
             {
                 txt_Titulo.Text = titulo;
                 ltb_SQL.Items.Add(sql);
                 dgv_Pesquisa.DataSource = (from o in banco.Orders
                                           group new { o.Customers, o } by new
                                           {
                                               o.Customers.CompanyName
                                           } into g
                                           select new
                                           {
                                               g.Key.CompanyName,
                                               Soma = (int?)g.Sum(p => p.o.OrderID)
                                           }).ToList();


                 }
             if (enumerador.Equals(Enumerador.QUINZE))
             {
                 txt_Titulo.Text = titulo;
                 ltb_SQL.Items.Add(sql);
                 dgv_Pesquisa.DataSource = (from o in banco.Orders
                                           group new { o.Customers, o } by new
                                           {
                                               o.Customers.CompanyName
                                           } into g
                                           select new
                                           {
                                               g.Key.CompanyName,
                                               Soma = (int?)g.Sum(p => p.o.OrderID)
                                           }).ToList();



                 }
        }
        private void frm_Pesquisa_Load(object sender, EventArgs e)
        {
        }
    }
}
