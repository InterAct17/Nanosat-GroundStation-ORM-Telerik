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
    public static class FillGrid
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(FillGrid));

        public static void fillSessionOperationGrid(DataGridView g, List<V_session_operation_list> sos, ToolStripStatusLabel label)
        {
            try
            {
                g.Rows.Clear();
                g.Columns.Clear();

                g.Columns.Add("id", "Ідентифікатор");
                g.Columns["id"].Visible = false;

                g.Columns.Add("priority", "Пріорітет");
                g.Columns.Add("command_control_type", "Строка керування");
                g.Columns.Add("is_not_arragment", "Не компонувати");
                g.Columns.Add("device_name", "(Адр.) Пристрій");
                g.Columns.Add("parameter_name", "(Адр.) Параметер");
                g.Columns.Add("type", "Операція");
                g.Columns.Add("value", "Значення");

                g.RowCount = sos.Count;
                g.RowHeadersVisible = false;

                for (int i = 0; i < sos.Count; i++)
                {
                    //g.Rows[i].HeaderCell.Value = sos[i].id.ToString();
                    g["id", i].Value = sos[i].Id;
                    g["priority", i].Value = sos[i].Priority;
                    g["command_control_type", i].Value = (CommandControlType)sos[i].Command_control_type;
                    g["is_not_arragment", i].Value = sos[i].Is_not_arragment;
                    g["device_name", i].Value = sos[i].Device_name;
                    g["parameter_name", i].Value = sos[i].Parameter_name;
                    g["type", i].Value = sos[i].Type;
                    g["value", i].Value = sos[i].Value;
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
                //  String devName = row.Cells["device_name"].Value.ToString();
                //  row.Cells["device_name"].Style.BackColor = Color.FromArgb((new Random(devName[0].GetHashCode()).Next(150, 255)), (new Random(devName[1].GetHashCode()).Next(180, 255)), (new Random(devName.GetHashCode()).Next(100, 255)));

                if (row.Cells["type"].Value.ToString() == "WRITE")
                {
                    row.Cells["type"].Style.ForeColor = Color.Red;
                }
                else if (row.Cells["type"].Value.ToString() == "READ")
                {
                    row.Cells["type"].Style.ForeColor = Color.Blue;
                    row.Cells["value"].Style.ForeColor = Color.DarkGray;
                }

                if ((CommandControlType)row.Cells["command_control_type"].Value != CommandControlType.NONE)
                {
                    row.Cells["command_control_type"].Style.ForeColor = Color.DarkGreen;
                    row.Cells["command_control_type"].Style.BackColor = Color.LightBlue;
                }

                if ((Boolean)row.Cells["is_not_arragment"].Value)
                {
                    row.Cells["is_not_arragment"].Style.BackColor = Color.LightCoral;
                }
            }

            foreach (DataGridViewColumn column in g.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public static void fillSessionOperationGrid(C1.Win.C1FlexGrid.C1FlexGrid g, List<V_session_operation_list> sos, ToolStripStatusLabel label)
        {
            try
            {
                g.Rows.Count = 1;
                g.Rows.Count = sos.Count + 1;

                for (int i = 0; i < sos.Count; i++)
                {
                    //g.Rows[i].HeaderCell.Value = sos[i].id.ToString();
                    g.Rows[i + 1]["id"] = sos[i].Id;
                    g.Rows[i + 1]["priority"] = sos[i].Priority;
                    g.Rows[i + 1]["command_control_type"] = (CommandControlType)sos[i].Command_control_type;
                    g.Rows[i + 1]["is_not_arragment"] = sos[i].Is_not_arragment;
                    g.Rows[i + 1]["device_name"] = sos[i].Device_name;
                    g.Rows[i + 1]["parameter_name"] = sos[i].Parameter_name;
                    g.Rows[i + 1]["type"] = sos[i].Type;
                    g.Rows[i + 1]["value"] = sos[i].Value;
                }
                //g.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Nodes;
                
                g.AutoSizeCols();
                sessionGrid_Paint(g);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        public static void sessionGrid_Paint(C1.Win.C1FlexGrid.C1FlexGrid g)
        {
            List<Color> lc = new List<Color>() { Color.DarkGray, Color.DarkGreen, Color.Yellow, Color.Gold, Color.Purple };
            List<String> devNames = new List<String>();

            initStyles(g);
            for (int i = 1; i < g.Rows.Count; i++)
            {
                String devName = g[i, "device_name"].ToString();
                C1.Win.C1FlexGrid.CellStyle cs = g.Styles.Add(devName);
                cs.BackColor = Color.FromArgb((new Random(devName[0].GetHashCode()).Next(150, 255)), (new Random(devName[1].GetHashCode()).Next(180, 255)), (new Random(devName.GetHashCode()).Next(100, 255)));
                g.SetCellStyle(i, g.Cols["device_name"].Index, devName);

                if (g[i, "type"].ToString() == "WRITE")
                {
                    g.SetCellStyle(i, g.Cols["type"].Index, "w");
                }
                else if (g[i, "type"].ToString() == "READ")
                {
                    g.SetCellStyle(i, g.Cols["type"].Index, "r");
                    g.SetCellStyle(i, g.Cols["value"].Index, "r_value");
                }

                if ((CommandControlType)g[i, "command_control_type"] != CommandControlType.NONE)
                {
                    g.SetCellStyle(i, g.Cols["command_control_type"].Index, "command_control_type");
                }

                if ((Boolean)g[i, "is_not_arragment"])
                {
                    g.SetCellStyle(i, g.Cols["is_not_arragment"].Index, "is_not_arragment");
                }
            }
        }

        private static void initStyles(C1.Win.C1FlexGrid.C1FlexGrid g)
        {
            C1.Win.C1FlexGrid.CellStyle cs = g.Styles.Add("w");
            cs.ForeColor = Color.Red;

            cs = g.Styles.Add("r");
            cs.ForeColor = Color.Blue;

            cs = g.Styles.Add("r_value");
            cs.ForeColor = Color.DarkGray;

            cs = g.Styles.Add("command_control_type");
            cs.ForeColor = Color.DarkGreen;
            cs.BackColor = Color.LightBlue;            

            cs = g.Styles.Add("is_not_arragment");
            cs.BackColor = Color.LightCoral;
        }
    }
}
