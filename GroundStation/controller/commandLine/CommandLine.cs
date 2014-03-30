using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GroundStation.view;
using log4net;
using GroundStation.model.entity.telerik;

namespace controller
{
    public enum CommandControlType { 
        NONE,
        IF_CMD,
        WAIT_CMD,
        WAIT_SWITCH_CMD
    }

    public class CommandLine
    {
        SessionOperationListManager dsol = new SessionOperationListManager();
        ParametersManager dp = new ParametersManager();
        CommandControlManager dcc = new CommandControlManager();
        QuestionFrm qf;
        public static readonly ILog log = LogManager.GetLogger(typeof(CommandLine));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="so"></param>
        /// <param name="value"></param>
        /// <returns>Наступний пріорітет переходу: якщо -1 перехід відміняється</returns>
        public long? analysis(Session_operation_list so, Double value)
        {

            switch (so.Command_control_type)
            {
                case 1: return ifLogicCommand(so.Operation_group_id, dcc.getCommandControl(so.Id), value);
                case 2: break;
                case 3: return waitSwitchCommand(so.Operation_group_id, dcc.getCommandControlList(so.Id), value);
                default: log.Error("Unknown command line!!!"); break;
            }

            return -1;
        }

        private long? ifLogicCommand(long? operation_group_id, Command_control cc, Double value)
        {
            string desc = cc.Expression + " value = " + value;
            string pname = dp.getParameter(dsol.getSessionOperationById(cc.Next_session_operation_id).Parameter_id).Name;
            qf = new QuestionFrm();
            if (TranslatorLogicalExpressions.expressionValue(cc.Expression.Replace("value", value.ToString())))
            {
                if (qf.showLogicCommand(desc, pname, (DialogType)cc.Show_dialog_type, cc.Show_dialog_time) == System.Windows.Forms.DialogResult.Yes)
                {
                    List<V_session_operation_list> vsol = dsol.getVSessionOperationList(operation_group_id);
                    for (int i = 0; i < vsol.Count; i++)
                    {
                        if (vsol[i].Id == cc.Next_session_operation_id) return vsol[i].Priority;
                    }
                    log.Error("ifLogicCommand(CommandControl cc, Double value) Unknown next_session_operation_id !!!");
                }
            }
            return -1;
        }

        private long? waitSwitchCommand(long? operation_group_id, List<Command_control> cc, Double value)
        {
            List<V_session_operation_list> vsol = dsol.getVSessionOperationList(operation_group_id);
                qf = new QuestionFrm();
                string desc = "Оберіть одну з наступних строк перехду.";
                
                if (qf.showWaitSwitchCommand(desc, cc, vsol) == System.Windows.Forms.DialogResult.Yes)
                {                                    
                    for (int i = 0; i < vsol.Count; i++)
                    {
                        if (vsol[i].Id == qf.selectedNextSessionOperationId) return vsol[i].Priority;
                    }
                    log.Error("waitSwitchCommand(CommandControl cc, Double value) Unknown next_session_operation_id !!!");
                }         

            return -1;
        }

        // Overload func

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="so"></param>
        /// <param name="value"></param>
        /// <returns>Наступний пріорітет переходу: якщо -1 перехід відміняється</returns>
        public long? analysis(V_session_operation_list_arragment so, Double value)
        {            
            switch (so.Command_control_type)
            {
                case 1: return ifLogicCommand(so.Operation_group_id, dcc.getCommandControl(so.Session_operation_list_id), value);
                case 2: break;
                case 3: return waitSwitchCommand(so.Operation_group_id, dcc.getCommandControlList(so.Session_operation_list_id), value);
                default: log.Error("Unknown command line!!!"); break;
            }

            return -1;
        }
    }
}
