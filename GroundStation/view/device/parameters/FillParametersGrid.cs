using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using log4net;
using controller;
using GroundStation.model.entity.telerik;

namespace GroundStation.view
{
    public static class FillParametersGrid
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(FillParametersGrid));

        public static void fillSessionOperationGrid(DataGridView g, List<V_parameter> vp)
        {
            try
            {
                g.Rows.Clear();
                g.Columns.Clear();

                g.Columns.Add("id", "Identification");
                g.Columns["id"].Visible = false;

                g.Columns.Add("calculation_formula_id", "Calc formula");         
                g.Columns.Add("register_address_start", "ModBus ADR");
                g.Columns.Add("modbus_type_name", "Type");
                g.Columns.Add("access_name", "Access");
                g.Columns.Add("name", "Parameter name");
                g.Columns.Add("description", "Parameter description");                   

                g.RowCount = vp.Count;
                g.RowHeadersVisible = false;

                for (int i = 0; i < vp.Count; i++)
                {
                    g["id", i].Value = vp[i].Id;
                    g["calculation_formula_id", i].Value = vp[i].Calculation_formula_id;
                    g["register_address_start", i].Value = vp[i].Register_address_start;
                    g["modbus_type_name", i].Value = vp[i].Modbus_type_name;
                    g["access_name", i].Value = vp[i].Access_name;
                    g["name", i].Value = vp[i].Name;
                    g["description", i].Value = vp[i].Description;                    
                }
                sessionGrid_Paint(g);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        public static void sessionGrid_Paint(DataGridView g)
        {
            List<Color> lc = new List<Color>() { Color.DarkGray, Color.DarkGreen, Color.Yellow, Color.Gold, Color.Purple };
            List<String> devNames = new List<String>();

            foreach (DataGridViewRow row in g.Rows)
            {
                if (row.Cells["access_name"].Value.ToString() == "READ")
                {
                    row.Cells["access_name"].Style.ForeColor = Color.Blue;
                }
                else if (row.Cells["access_name"].Value.ToString() == "READ-WRITE")
                {
                    row.Cells["access_name"].Style.ForeColor = Color.Red;                    
                }               
            }

            foreach (DataGridViewColumn column in g.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
            g.Columns["calculation_formula_id"].Width = 80;
            g.Columns["calculation_formula_id"].Resizable = DataGridViewTriState.False;
            g.Columns["register_address_start"].Width = 80;
            g.Columns["register_address_start"].Resizable = DataGridViewTriState.False;
            g.Columns["modbus_type_name"].Width = 100;            
            g.Columns["access_name"].Width = 100;       
        }
    }
}
