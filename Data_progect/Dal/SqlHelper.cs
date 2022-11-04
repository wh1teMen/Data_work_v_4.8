using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;


namespace Data_progect.Dal
{
    internal class SqlHelper 
    {

        internal static List<OutBase> GetData()
        {
            string databaseName = "project.db";                    
           string dataname = Form6.month;        
            try
                {

                    using (SQLiteConnection conection = new SQLiteConnection(string.Format("Data Source={0};", databaseName)))
                    {
                        conection.Open();
                        using (var comand = new SQLiteCommand($"SELECT id, Rem_karta, Kontragent, Baraban, Value_, Price, Price_material, Profit FROM \"{dataname}\"", conection))

                        {

                            using (var rdr = comand.ExecuteReader())
                            {
                                List<OutBase> outdata = new List<OutBase>();
                                while (rdr.Read())
                                {
                                    outdata.Add(new OutBase
                                    {
                                        Id = rdr.GetInt32(0),
                                        Rem_karta = rdr.GetInt32(1),
                                        Kontragent = rdr.GetString(2),
                                        Baraban = rdr.GetInt32(3),
                                        Value_ = rdr.GetInt32(4),
                                        Price = rdr.GetDecimal(5),
                                        Price_material = rdr.GetDecimal(6),
                                        Profit = rdr.GetString(7)
                                    });                                
                                }
                                return outdata;
                            }
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                return null;
            }        
        }
    }

