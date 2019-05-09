using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Generic;

namespace Exercise_0505
{
    public partial class HexPage : System.Web.UI.Page
    {
        int number = 10;    // selected number for multiplication list

        //int[] numDec = new int[] { 10, 11, 12, 13, 14, 15 };
        //string[] numHex = new string[] { "A", "B", "C", "D", "E", "F" };

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
                h1.Text = "Multiplication Table: Hex";
                lbSelect.Text = "Select a number of multiplication table: ";
                CreateHex(number);
            }
        }

        public void CreateHex(int num)
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
            cal = changeHex(i, j);
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
        //Change to Hex
        //**************
        private string changeHex(int i, int j)
        {
            cal = "";
            int result = i * j;
            int resultHex;
            int reminder;

            resultHex = result / 16;
            reminder = result % 16;

            if (resultHex == 0)
            {
                if (reminder < 10)
                {
                    cal = (i * j).ToString();
                }
                else
                {
                    switch (reminder)
                    {
                        case 10: cal = "A"; break;
                        case 11: cal = "B"; break;
                        case 12: cal = "C"; break;
                        case 13: cal = "D"; break;
                        case 14: cal = "E"; break;
                        case 15: cal = "F"; break;
                    }
                }
            }
            else if (resultHex < 10)
            {
                if (reminder < 10)
                {
                    cal = (resultHex * 10 + reminder).ToString();
                }
                else
                {
                    switch (reminder)
                    {
                        case 10: cal = resultHex + "A"; break;
                        case 11: cal = resultHex + "B"; break;
                        case 12: cal = resultHex + "C"; break;
                        case 13: cal = resultHex + "D"; break;
                        case 14: cal = resultHex + "E"; break;
                        case 15: cal = resultHex + "F"; break;
                    }
                }
            }
            else if (resultHex >= 10)
            {
                if (reminder < 10)
                {
                    switch (resultHex)
                    {
                        case 10: cal = "A" + reminder.ToString(); break;
                        case 11: cal = "B" + reminder.ToString(); break;
                        case 12: cal = "C" + reminder.ToString(); break;
                        case 13: cal = "D" + reminder.ToString(); break;
                        case 14: cal = "E" + reminder.ToString(); break;
                        case 15: cal = "F" + reminder.ToString(); break;
                    }
                }
                else
                {
                    switch (resultHex)
                    {
                        case 10:
                            cal = "A";
                            switch (reminder)
                            {
                                case 10: cal = cal + "A"; break;
                                case 11: cal = cal + "B"; break;
                                case 12: cal = cal + "C"; break;
                                case 13: cal = cal + "D"; break;
                                case 14: cal = cal + "E"; break;
                                case 15: cal = cal + "F"; break;
                            }
                            break;
                        case 11:
                            cal = "B";
                            switch (reminder)
                            {
                                case 10: cal = cal + "A"; break;
                                case 11: cal = cal + "B"; break;
                                case 12: cal = cal + "C"; break;
                                case 13: cal = cal + "D"; break;
                                case 14: cal = cal + "E"; break;
                                case 15: cal = cal + "F"; break;
                            }
                            break;
                        case 12:
                            cal = "C";
                            switch (reminder)
                            {
                                case 10: cal = cal + "A"; break;
                                case 11: cal = cal + "B"; break;
                                case 12: cal = cal + "C"; break;
                                case 13: cal = cal + "D"; break;
                                case 14: cal = cal + "E"; break;
                                case 15: cal = cal + "F"; break;
                            }
                            break;
                        case 13:
                            cal = "D";
                            switch (reminder)
                            {
                                case 10: cal = cal + "A"; break;
                                case 11: cal = cal + "B"; break;
                                case 12: cal = cal + "C"; break;
                                case 13: cal = cal + "D"; break;
                                case 14: cal = cal + "E"; break;
                                case 15: cal = cal + "F"; break;
                            }
                            break;
                        case 14:
                            cal = "E";
                            switch (reminder)
                            {
                                case 10: cal = cal + "A"; break;
                                case 11: cal = cal + "B"; break;
                                case 12: cal = cal + "C"; break;
                                case 13: cal = cal + "D"; break;
                                case 14: cal = cal + "E"; break;
                                case 15: cal = cal + "F"; break;
                            }
                            break;
                        case 15:
                            cal = "F";
                            switch (reminder)
                            {
                                case 10: cal = cal + "A"; break;
                                case 11: cal = cal + "B"; break;
                                case 12: cal = cal + "C"; break;
                                case 13: cal = cal + "D"; break;
                                case 14: cal = cal + "E"; break;
                                case 15: cal = cal + "F"; break;
                            }
                            break;
                    }
                }
            }
            return cal;
        }

        public void Number_Changed(object sender, EventArgs e)
        {
            string s = dList.SelectedValue;
            number = Int32.Parse(s);
            CreateHex(number);
        }

        private int getNumber()
        {
            string s = dList.SelectedValue;
            number = Int32.Parse(s);
            return number;
        }

    }
}