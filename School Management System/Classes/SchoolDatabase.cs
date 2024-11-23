using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
//private static string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=sys;Password=1234;DBA Privilege=SYSDBA;";

public static class SchoolDatabase {
    private static string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=admin;Password=123;";
    public static DataTable ExecuteQuery(string query, OracleParameter[] parameters = null) {
        DataTable dataTable = new DataTable();

        using (OracleConnection connection = new OracleConnection(connectionString)) {
            using (OracleCommand command = new OracleCommand(query, connection)) {
                if (parameters != null) {
                    command.Parameters.AddRange(parameters);
                }

                try {
                    connection.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command)) {
                        adapter.Fill(dataTable);
                    }
                }
                catch (OracleException ex) {
                    MessageBox.Show("Oracle Error: " + ex.Message);
                    throw;
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                    throw;
                }
            }
        }

        return dataTable;
    }
    public static int ExecuteNonQuery(string query, OracleParameter[] parameters = null) {
        int rowsAffected = 0;

        using (OracleConnection connection = new OracleConnection(connectionString)) {
            using (OracleCommand command = new OracleCommand(query, connection)) {
                if (parameters != null) {
                    command.Parameters.AddRange(parameters);
                }

                try {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                    // Log the INSERT statement with values
                    if (query.TrimStart().ToUpper().StartsWith("INSERT INTO")) {
                        LogInsertStatement(command);
                    }
                }
                catch (OracleException ex) {
                    MessageBox.Show("Oracle Error: " + ex.Message);
                    throw;
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                    throw;
                }
            }
        }

        return rowsAffected;
    }

    private static void LogInsertStatement(OracleCommand command) {
        string logFilePath = "insert_log.txt"; 

        string insertStatement = command.CommandText;
        foreach (OracleParameter parameter in command.Parameters) {
            // Replace parameter placeholders with actual values
            insertStatement = insertStatement.Replace(
                parameter.ParameterName,
                parameter.Value == DBNull.Value ? "NULL" : $"'{parameter.Value.ToString().Replace("'", "''")}'");
        }

        using (StreamWriter writer = new StreamWriter(logFilePath, true)) {
            writer.WriteLine($"{insertStatement};");
        }
    }
}