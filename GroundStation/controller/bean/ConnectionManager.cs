using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Configuration;
using log4net;
using log4net.Config;
using GroundStation.model.entity.telerik;

namespace controller
{
    public static class ConnectionManager
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(ConnectionManager));
        //ConfigurationSettings.AppSettings
        private static string connString = ConfigurationManager.AppSettings["ConnectionStringPostgreSQL"];

        private static SatelliteModelTelerik entities = new SatelliteModelTelerik();

        public static SatelliteModelTelerik getEntities()
        {
            try
            {
                if (entities != null)
                {
                    return entities;
                }

                throw new Exception("Entities object is NULL!");
            }
            catch (Exception ex)
            {
                log.Error("DataBase getSatelliteEntities() " + ex.Message);
            }
            
            return null;
        }
        /// <summary>
        /// Зберігає всі зміни в сутностях
        /// </summary>
        /// <returns>Кількість об'єктів які були змінені</returns>
        public static int saveEntitiesChanges()
        {
            int count = -1;
                entities.SaveChanges();
            log.Debug("Count object change: " + count);
            return count;
        }

        public static NpgsqlConnection getConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                log.Debug("DataBase getConnection() successfully");
                return conn;
            }
            catch (Exception ex)
            {
                log.Error("DataBase getConnection() " + ex.Message);
            }

            return null;
        }
    }
}
