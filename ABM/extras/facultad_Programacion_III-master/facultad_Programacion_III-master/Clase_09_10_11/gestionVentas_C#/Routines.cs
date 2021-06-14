using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Clases de Input Output, para el Manejo de Archivos
using System.IO;
//Clases para ADO, para la Conexion con la DB
using System.Data.SqlClient;
//Clases para Envio y Recepcion de Mails.
using System.Net.Mail;
using Microsoft.VisualBasic;

namespace sistema
{
    class Routines
    {
        /**Para la Validaciones al Crear Un Nuevo Cliente o Proveedor*/
        internal static bool checkSave { get; set; }
        /**Para Mostrar el Usuario Logeado*/
        internal static string  nameUser { get; set; }
        internal static string lastNameUser { get; set; }
        /**Para la conexión a la dB*/
        public SqlConnection Conectar()
        {
            SqlConnection connection = new SqlConnection(System.Convert.ToString(LeerConfig()));
            return connection;

        }
        public string LeerConfig()
        {
            // En le archivo hostDb.txt poner la instancia de SQL p. ej: BAUBYTE-NOTE\SQLEXPRESS14
            if (File.Exists(@"C:\Connections\ConfigDb.txt") == true)
            {
                // Abrimos el Archivo y Guaardamos el contenido en SR
                StreamReader SR = File.OpenText(@"C:\Connections\ConfigDb.txt");
                // Leemos las lineas hasta el enter y guardamos en Line
                string Line = SR.ReadLine();
                // Cerramos el archivo
                SR.Close();
                // Devolvemos la linea que leida
                return Line;
            }

            return default;
        }
        // Para comprobar si existe en la DB
        public bool YaExisteSql(string sql)
        {
            bool salida = true;
            // Le pasamos un SELECT de SQL que en teoria busca algo, por ejemplo un numero de cheque, si hay registros la Funcion devuelve 
            // True, estilo "el cheque ya existe", si no esta, devuelve False
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Conectar());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "existe");
            if (dataSet.Tables["existe"].Rows.Count < 1)
            {
                salida = false;
            }
            else
            {
                salida = true;
            }
            return salida;
        }
        // Para convertir los String o Num
        public decimal Vnum(string NTexto)
        {
            // transforma un texto con algo, que puede ser un numero con coma o punto o perro, y devuelve un valor decimal siempre
            return System.Convert.ToDecimal(Conversion.Val(NTexto.Trim().Replace(",", ".")));
        }
        // Para convertir los Numeros en el formato correcto para SQL 
        public string NumSql(string numero)
        {
            // Recibe un número desde un textbox por ejemplo, lo verifica como número válido, 
            // y luego le cambia la coma por punto para que sea válido en una sentencia de sql,
            // luego lo devuelve
            return System.Convert.ToString(Vnum(numero)).Trim().Replace(",", ".");
        }
        // Para Rellenar los Numeros con la cantidad que necesitemos
        public string RellenaNum(int numero, int cantidad)
        {
            // Rellena con 0s adelante el numero. Ideal para dias y meses:
            // RellenaNum(3,2)---> "03" RellenaNum(3,4)--->"0003"
            string snum = System.Convert.ToString(numero).Trim();
            return "00000000000000000000".Substring(0, cantidad - snum.Length) + snum;
        }
        // Para Formatear las Fechas en el formato correcto para SQL 
        public string FechaSql(DateTime fecha)
        {
            // Devuelve fecha en el formato 'AAAAMMDD'
            return "'" + RellenaNum(fecha.Year, 4) + RellenaNum(fecha.Month, 2) + RellenaNum(fecha.Day, 2) + "'";
        }
        // Ejecuta las distintas acciones del ABM
        public bool SqlAccion(string SqlDeAccion)
        {
            // Ejecuta la consulta de accion 'SqlDeAccion' abriendo la conexion automaticamente
            // se da cuenta si es de insert, update o delete, porque mira dentro de la sentencia que se le pasa
            // devuelve true si se pudo hacer, y false si hubo algún error
            // Para despues idicarle las consultas o un store procedure de SQL
            SqlConnection connection = Conectar();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            // Para ver si hubo o no error en la ejecucion
            bool salida = true;
            try
            {
                connection.Open();
                // Buscamos en el contenido con IndexOf si tiene algunas de las acciones
                if ((SqlDeAccion.ToString().ToUpper().IndexOf("INSERT")) != -1)
                {
                    dataAdapter.InsertCommand = new SqlCommand(SqlDeAccion, connection);
                    dataAdapter.InsertCommand.ExecuteNonQuery();
                }
                else if ((SqlDeAccion.ToUpper().IndexOf("UPDATE")) != -1)
                {
                    dataAdapter.UpdateCommand = new SqlCommand(SqlDeAccion, connection);
                    dataAdapter.UpdateCommand.ExecuteNonQuery();
                }
                else if ((SqlDeAccion.ToUpper().IndexOf("DELETE")) != -1)
                {
                    dataAdapter.DeleteCommand = new SqlCommand(SqlDeAccion, connection);
                    dataAdapter.DeleteCommand.ExecuteNonQuery();
                }
                else
                    // esta mal la sintaxis porque no hay ni insert, ni delete ni update
                    salida = false;
            }
            // Capturamos el Error
            catch (Exception ex)
            {
                // Mostaramos el Error y Devolvemos False en la salida es decir que todo salio mal
                Interaction.MsgBox(ex.Message);
                salida = false;
            }
            // Cerramos la Conexion y Devolvemos True en la salida es decir que todo salio bien
            connection.Close();
            return salida;
        }

    }
}
