using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Lotto
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var result = new DataReaderFromCSV().GetExtractions("lottoR.csv");
            //gridControl1.DataSource = result;
            //new DataAnalyser(result).GetProcentage();
            gridControl1.DataSource = new DataAnalyser(result).GetTableResults();

            
        }

        //private DataTable GetKombinacije()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Clear();
        //    //DataColumn dc = new DataColumn("I", Type.GetType("int"));
        //    dt.Columns.Add(new DataColumn("RBr", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("I", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("II", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("III", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("IV", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("V", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("VI", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("VII", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("Par", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("Nepar", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("Suma", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("DI", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("DII", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("DIII", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("DIV", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("DV", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("DVI", Type.GetType("System.Int32")));
        //    dt.Columns.Add(new DataColumn("DVII", Type.GetType("System.Int32")));
        //    DataRow _red;

        //    int[] numbersCount = new int[40];
        //    int nepar;
        //    int suma;
        //    int rbr = 0;

        //    //string[] displayResult = new string[40];

        //    for (int i = 1; i < 40; i++)
        //    {
        //        for (int ii = i+1; ii < 40; ii++)
        //        {
        //            for (int iii = ii+1; iii < 40; iii++)
        //            {
        //                for (int iv = iii+1; iv < 40; iv++)
        //                {
        //                    for (int v = iv+1; v < 40; v++)
        //                    {
        //                        for (int vi = v+1; vi < 40; vi++)
        //                        {
        //                            for (int vii = vi+1; vii < 40; vii++)
        //                            {
        //                                rbr += 1;
        //                                _red = dt.NewRow();
        //                                _red["RBr"] = rbr;
        //                                _red["I"] = i;// extraction.NumbersAsArray[0];
        //                                _red["II"] = ii;// extraction.NumbersAsArray[1];
        //                                _red["III"] = iii;// extraction.NumbersAsArray[2];
        //                                _red["IV"] = iv;// extraction.NumbersAsArray[3];
        //                                _red["V"] = v;// extraction.NumbersAsArray[4];
        //                                _red["VI"] = vi;// extraction.NumbersAsArray[5];
        //                                _red["VII"] = vii;// extraction.NumbersAsArray[6];
        //                                nepar = Math.Abs((int)Math.IEEERemainder(i, 2)) + Math.Abs((int)Math.IEEERemainder(ii, 2)) + Math.Abs((int)Math.IEEERemainder(iii, 2)) + Math.Abs((int)Math.IEEERemainder(iv, 2)) + Math.Abs((int)Math.IEEERemainder(v, 2)) + Math.Abs((int)Math.IEEERemainder(vi, 2)) + Math.Abs((int)Math.IEEERemainder(vii, 2));
        //                                _red["Nepar"] = nepar;
        //                                _red["Par"] = 7 - nepar;
        //                                suma = i + ii + iii + iv + v + vi + vii;
        //                                _red["Suma"] = suma;

        //                                _red["DI"] = i - i % 10;
        //                                _red["DII"] = ii - ii % 10;
        //                                _red["DIII"] = iii - iii % 10;
        //                                _red["DIV"] = iv-iv % 10;
        //                                _red["DV"] = v-v % 10;
        //                                _red["DVI"] = vi-vi % 10;
        //                                _red["DVII"] = vii-vii % 10;
        //                                dt.Rows.Add(_red);
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return dt;
        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //gridView2.Export(DevExpress.XtraPrinting.ExportTarget.Csv, "Kombinacije.csv");
        }

        //private void calcEdit1_EditValueChanged(object sender, EventArgs e)
        //{
        //    var result2 = new DataReaderFromCSV().GetExtractions(string.Format("Komb{0}.csv",calcEdit1.EditValue));
        //    gridControl2.DataSource = new DataAnalyser(result2).GetTableResults();
        //}
    }
}