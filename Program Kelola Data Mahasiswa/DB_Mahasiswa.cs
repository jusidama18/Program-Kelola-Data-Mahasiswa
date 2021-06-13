using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

// Nama : Juan Simon Damanik
// NIM : 8020190358
// Kelas : 02 PT 4 Pemrograman Visual

namespace Program_Kelola_Data_Mahasiswa
{
    public class DB_Mahasiswa
    {
        public static OleDbConnection connect;  // Connecting app to Database
        public static OleDbCommand command; // Command app to access Database
        public static OleDbDataReader read; // For app to read Database

        public static OleDbDataAdapter dataMhs; //Connect to table from Database
        public static DataTable tableMhs = new DataTable(); // Setting Data in Table
        
        // Connecting Process
        public static OleDbConnection Connect_DB()
        {

            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0; Data Source=DB_Mahasiswa.accdb");
            connect.Open();
            return connect;
        }

    }
}
