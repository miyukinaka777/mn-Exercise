using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Generic;

namespace Exercise_0505
{
    public partial class Default : System.Web.UI.Page
    {
        int number = 10;    // selected number for multiplication list

        string td = "<td align='center' width='50' height='30' ";
        string bgBlue = "bgcolor='#ADD8E6' ";
        string bgYellow = "bgcolor='#FFFF00' ";
        string bgPink = "bgcolor='#FFB6C1' ";
        string bgWhite = "bgcolor='#FFFFFF' ";

        string cal;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                h1.Text = "Multiplication Table: Decimal";
                lbSelect.Text = "Select a number of multiplication table: ";
                CreateDecimal(number);
            }
        }

        //*************************************************
        //  Decimal Table
        //*************************************************
        public void CreateDecimal(int num)
        {
            cal = "";
            int numrow = num + 1;
            int numcol = num + 1;

            for (int i = 0; i < numrow; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < numcol; j++)
                {
                    if (i == 0 && j == 0)   // First cell (0,0)
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl
                            (td + bgWhite + " class='first-cell first-row' >X</td>"));
                        row.Cells.Add(c);
                    }
                    else if (i == 0)        // First Row
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl
                            (td + bgBlue + " class='first-row' >" + j.ToString() + "</td>"));
                        row.Cells.Add(c);
                    }
                    else
                    {
                        if (j == 0)         // First Column
                        {
                            TableCell c = new TableCell();
                            c.Controls.Add(new LiteralControl
                                (td + bgBlue + " class='first-col' >" + i.ToString() + "</td>"));
                            row.Cells.Add(c);
                        }
                        else if (i == j)    // change Background color for same numbers multiplication
                        {
                            Calculate(i, j, row);
                        }
                        else
                        {
                            Calculate(i, j, row);
                        }
                    }
                }
                table1.Rows.Add(row);
            }

        }

        //*************************************************
        //  Calculate and check Prime number
        //*************************************************
        private void Calculate(int i, int j, TableRow row)
        {
            bool prime = false;               
            prime = PrimeNumber(i, j);
            TableCell cell = new TableCell();
            cal = (i * j).ToString();
            string tooltip = (i + "X" + j + "=" + cal).ToString();

            if (prime)
            {
                cell.Controls.Add(new LiteralControl
                    (td + bgYellow + " class='col' title ='" + tooltip + "' >" + cal + "</td>"));
            }
            else if (i == j)
            {
                cell.Controls.Add(new LiteralControl
                    (td + bgPink + " class='col' title ='" + tooltip + "' >" + cal + "</td>"));
            }
            else if (!prime)
            {
                cell.Controls.Add(new LiteralControl
                    (td + bgWhite + " class='col' title='" + tooltip + "' >" + cal + "</td>"));
            }
            row.Cells.Add(cell);
        }

        private bool PrimeNumber(int i, int j)
        {
            bool primeCheck = false;
            int result = i * j;
            int n = 0;
            n = result / 2;

            if (result == 1)
            {
                primeCheck = false;
            }
            else if (result == 2)
            { 
                primeCheck = true;
            }
            else if (result > 2)
            {
                for (int x = 2; x < n; x++)
                {
                    if (result % x == 0)
                    {
                        primeCheck = false;
                        break;
                    }
                    else
                    {
                        primeCheck = true;
                    }
                }
            }
            return primeCheck;
        }

        public void Number_Changed(object sender, EventArgs e)
        {
            string s = dList.SelectedValue;
            number = Int32.Parse(s);
            CreateDecimal(number);
        }

        public void Format_Changed(object sender, EventArgs e)
        {

        }

    }
}


