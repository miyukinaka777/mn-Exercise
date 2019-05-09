using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Generic;

namespace Exercise_0505
{

    public partial class BinaryPage : System.Web.UI.Page
    {
        int number = 10;    // selected number for multiplication list

        string td = "<td align='center' width='50' height='30' ";
        string bgBlue = "bgcolor='#ADD8E6' ";
        //string bgYellow = "bgcolor='#FFFF00' ";
        string bgPink = "bgcolor='#FFB6C1' ";
        string bgWhite = "bgcolor='#FFFFFF' ";

        string cal;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                h1.Text = "Multiplication Table: Binary";
                lbSelect.Text = "Select a number of multiplication table: ";
                CreateBinary(number);
            }
        }

        //*************************************************
        //  Binary Table
        //*************************************************
        public void CreateBinary(int num)
        {
            cal = "";
            int numrow = num + 1;
            int numcol = num + 1;

            for (int i = 0; i < numrow; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < numcol; j++)
                {
                    if (i == 0 && j == 0)   // cell:(0, 0) = X
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

        private void Calculate(int i, int j, TableRow row)
        {
            TableCell cell = new TableCell();
            cal = changeBinary(i, j);
            string result = (i * j).ToString();
            string tooltip = (i + "X" + j + "=" + result).ToString();

            if (i == j)
            {
                cell.Controls.Add(new LiteralControl
                    (td + bgPink + " class='col' title ='" + tooltip + "' >" + cal + "</td>"));
            }
            else 
            {
                cell.Controls.Add(new LiteralControl
                    (td + bgWhite + " class='col' title='" + tooltip + "' >" + cal + "</td>"));
            }
            row.Cells.Add(cell);
        }

        //**************
        //Change to Binary
        //**************
        private string changeBinary(int i, int j)
        {
            cal = "";
            int[] bin = new int[10];
            int result = i * j;
            int x;
            for (x = 0; result > 0; x++)
            {
                bin[x] = result % 2;
                result = result / 2;
            }

            for (x = x - 1; x >= 0; x--)
            {
                cal = cal + bin[x].ToString();
            }
            return cal;
        }

        public void Number_Changed(object sender, EventArgs e)
        {
            string s = dList.SelectedValue;
            number = Int32.Parse(s);
            CreateBinary(number);
        }

        private int getNumber()
        {
            string s = dList.SelectedValue;
            number = Int32.Parse(s);
            return number;
        }

    }
}
