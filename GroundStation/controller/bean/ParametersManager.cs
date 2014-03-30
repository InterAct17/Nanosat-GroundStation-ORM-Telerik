﻿///////////////////////////////////////////////////////////
//  parameters.cs
//  Implementation of the Class parameters
//  Generated by Enterprise Architect
//  Created on:      16-фев-2013 16:43:13
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
    /// Таблиця параметрів будується на основі modbus карти регістрів кожної системи
    /// </summary>
    public class ParametersManager
    {

        public static readonly ILog log = LogManager.GetLogger(typeof(ParametersManager));
        private DataSet ds = new DataSet();
        NpgsqlDataAdapter da;

        public List<V_parameter> getVParametersList(int devId)
        {                     
            try
            {
                return ConnectionManager.getEntities().V_parameters.Where(c => c.Device_id == devId).ToList();
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            return null;
        }

        public DataTable getParametersSimple(int devId)
        {
            NpgsqlConnection conn = ConnectionManager.getConnection();
            try
            {
                string sql = "SELECT id, name FROM parameters WHERE device_id=:device_id ORDER BY id";
                // data adapter making request from our connection
                da = new NpgsqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(":device_id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = devId;
                // i always reset DataSet before i do something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);

                // set header name for table
                ds.Tables[0].Columns["id"].ColumnName = "ID";
                ds.Tables[0].Columns["name"].ColumnName = "Назва";
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

        public Boolean addParameter(Parameter p)
        {            
            try
            {
                ConnectionManager.getEntities().Add(p);
                ConnectionManager.getEntities().SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }           
            return false;
        }

        public Boolean deleteParameter(int id_)
        {
            NpgsqlConnection conn = ConnectionManager.getConnection();
            try
            {
                string sql = "DELETE FROM parameters WHERE id=:id";
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

        public Parameter getParameter(long? _id)
        {
            try
            {
                return ConnectionManager.getEntities().Parameters.Where(c => c.Id == _id).FirstOrDefault();
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
            return null;
        }
    }//end Parameters

}//end namespace GraundStationDB