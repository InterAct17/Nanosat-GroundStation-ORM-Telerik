///////////////////////////////////////////////////////////
//  session_operation_list.cs
//  Implementation of the Class session_operation_list
//  Generated by Enterprise Architect
//  Created on:      16-���-2013 16:41:19
//  Original author: Ostrovskiy Ihor
///////////////////////////////////////////////////////////
using System.Data;
using System;
using Npgsql;
using log4net;
using log4net.Config;
using System.Collections.Generic;
using System.Linq;
using GroundStation.model.entity.telerik;

namespace controller
{
    /// <summary>
    /// ������ �������� �� ����������� �� ��� ������ ������
    /// </summary>
    public class SessionOperationListManager
    {

        public static readonly ILog log = LogManager.GetLogger(typeof(SessionOperationListManager));
        private DataSet ds = new DataSet();
        NpgsqlDataAdapter da;
        CommandControlManager dcc = new CommandControlManager();

        public DataTable getVSessionOperationComboBoxDataTable(long? selectedOperationGroupId)
        {

            NpgsqlConnection conn = ConnectionManager.getConnection();
            try
            {
                string sql = "SELECT id, name FROM v_session_operation_combo_box WHERE operation_group_id=" + selectedOperationGroupId;
                // data adapter making request from our connection
                da = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);

                return ds.Tables[0];
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return null;
        }

        public DataTable getSessionOperationDataTable(int selectedOperationGroupId)
        {
            NpgsqlConnection conn = ConnectionManager.getConnection();
            try
            {
                string sql = "SELECT * FROM session_operation_list WHERE operation_group_id=" + selectedOperationGroupId;
                // data adapter making request from our connection
                da = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);

                // set header name for table
                ds.Tables[0].Columns["id"].ColumnName = "�������������";
                ds.Tables[0].Columns["parameter_id"].ColumnName = "������������� ���������";
                ds.Tables[0].Columns["operation_group_id"].ColumnName = "����� ��������";
                ds.Tables[0].Columns["type"].ColumnName = "��� ��������";
                ds.Tables[0].Columns["value"].ColumnName = "�������� ��� ������";
                // since it C# DataSet can handle multiple tables, we will select first
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return null;
        }

        public List<Session_operation_list> getSessionOperationList(long selectedOperationGroupId)
        {
            try
            {
                return ConnectionManager.getEntities().Session_operation_lists.Where(c => c.Operation_group_id == selectedOperationGroupId).ToList();
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            return null;
        }

        public List<V_session_operation_list> getVSessionOperationList(long? selectedOperationGroupId)
        {
            try
            {
                return ConnectionManager.getEntities().V_session_operation_lists.Where(c => c.Operation_group_id == selectedOperationGroupId).ToList();
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            return null;
        }

        public List<V_session_operation_list_arragment> getVSessionOperationArragmentList(long selectedOperationGroupId)
        {
            try
            {
                return ConnectionManager.getEntities().V_session_operation_list_arragments.Where(c => c.Operation_group_id == selectedOperationGroupId).ToList();
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            return null;
        }

        public DataTable getSessionOperationDataTableView(int selectedOperationGroupId)
        {
            NpgsqlConnection conn = ConnectionManager.getConnection();
            ParametersManager param = new ParametersManager();
            DevicesManager dev = new DevicesManager();
            try
            {
                string sql = "SELECT * FROM v_session_operation_list WHERE operation_group_id=" + selectedOperationGroupId;
                // data adapter making request from our connection
                da = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);

                // set header name for table                
                //ds.Tables[0].Columns["operation_group_id"].ColumnName = "����� ��������";
                //ds.Tables[0].Columns["operation_group_id"].ColumnMapping = MappingType.Hidden;

                // ds.Tables[0].Columns["id"].ColumnName = "�������������";
                // ds.Tables[0].Columns["id"].ColumnMapping = MappingType.Hidden;
                ds.Tables[0].Columns["priority"].ColumnName = "�������";
                ds.Tables[0].Columns["device_name"].ColumnName = "����� �������";
                ds.Tables[0].Columns["parameter_name"].ColumnName = "����� ���������";
                ds.Tables[0].Columns["type"].ColumnName = "��� ��������";
                ds.Tables[0].Columns["value"].ColumnName = "�������� ��� ������";
                // since it C# DataSet can handle multiple tables, we will select first   
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return null;
        }

        public Boolean replaceSessionOperation(Session_operation_list op1, Session_operation_list op2)
        {            
            try
            {
                Int64 op1P = op1.Priority;
                op1.Priority = op2.Priority;
                op2.Priority = op1P;
                ConnectionManager.getEntities().SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            return false;
        }

        public Boolean addSessionOperation(Session_operation_list o)
        {            
            try
            {
                o.Priority = getMaxPriority(o);
                ConnectionManager.getEntities().Add(o);             
                ConnectionManager.getEntities().SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }

            return false;
        }

        public Boolean addSessionOperationList(long operationGroupId, List<Session_operation_list> sol)
        {
            NpgsqlConnection conn = ConnectionManager.getConnection();
            try
            {
                string sql = "INSERT INTO session_operation_list (parameter_id, operation_group_id, type, value, priority, command_control_type, is_not_arragment)"
                    + "VALUES (:parameter_id, :operation_group_id, :type, :value, :priority, :command_control_type, :is_not_arragment) RETURNING id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                foreach (Session_operation_list o in sol)
                {
                    cmd.Parameters.Add(":parameter_id", NpgsqlTypes.NpgsqlDbType.Smallint).Value = o.Parameter_id;
                    cmd.Parameters.Add(":operation_group_id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = operationGroupId;
                    cmd.Parameters.Add(":type", NpgsqlTypes.NpgsqlDbType.Integer).Value = o.Type;
                    cmd.Parameters.Add(":value", NpgsqlTypes.NpgsqlDbType.Integer).Value = o.Value;
                    cmd.Parameters.Add(":priority", NpgsqlTypes.NpgsqlDbType.Integer).Value = o.Priority;
                    cmd.Parameters.Add(":command_control_type", NpgsqlTypes.NpgsqlDbType.Integer).Value = o.Command_control_type;
                    cmd.Parameters.Add(":is_not_arragment", NpgsqlTypes.NpgsqlDbType.Boolean).Value = o.Is_not_arragment;

                    Int32 newSoId = Convert.ToInt32(cmd.ExecuteScalar());
                    dcc.addCommandControlList(newSoId, o.Command_controls.ToList());
                }

                return true;
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return false;
        }

        private Int32 getMaxPriority(Session_operation_list o)
        {
            NpgsqlConnection conn = ConnectionManager.getConnection();
            try
            {
                string sql = "SELECT MAX(priority + 1) FROM session_operation_list WHERE operation_group_id=:operation_group_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(":operation_group_id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = o.Operation_group_id;

                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr[0] != DBNull.Value)
                    return Convert.ToInt32(Convert.ToInt32(dr[0]));
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return 0;
        }


        public Boolean deleteSessionOperationById(int id_)
        {
            (new CommandControlManager()).deleteCommandControl(id_);
            NpgsqlConnection conn = ConnectionManager.getConnection();
            try
            {
                string sql = "DELETE FROM session_operation_list WHERE id=:id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(":id", NpgsqlTypes.NpgsqlDbType.Smallint).Value = id_;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return false;
        }

        public Session_operation_list getSessionOperationById(long? _id)
        {
            try
            {
                return ConnectionManager.getEntities().Session_operation_lists.Where(c => c.Id == _id).Single();         
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }

            return null;
        }

        public virtual void Dispose()
        {

        }
    }//end SessionOperationList

}//end namespace GraundStationDB