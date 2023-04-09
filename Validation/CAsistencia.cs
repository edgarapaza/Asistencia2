using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Windows.Forms;
using Twilio.Rest.Api.V2010.Account.Call;

namespace Asistencia2.Validation
{
    internal class CAsistencia
    {
        Conexion conn = new Conexion();

        public int VerificarAsistencia(string idpersonal)
        {
            // SI HA MARCADO ASISTENCIA DE INGRESO A LAS 8:00
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            int total = 0;

            try
            {
                string sql = "SELECT COUNT(*) AS total FROM gonsad.asistencia_registro WHERE idpersonal = " + idpersonal + " AND fecha = '" + fecha + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn.Conectar());
                string getValue = cmd.ExecuteScalar().ToString();
                total = Int32.Parse(getValue);

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Validacion: " + e.ToString());
            }

            return total;
        }

        public void AsistenciaIngreso(Label idpersonal, int llamada)
        {
            Datos datos = new Datos();


            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora_in = DateTime.Now.ToString("hh:mm:ss");
            int periodo = 1;
            
            
            int descuento = 0;

            //TimeSpan targetTime = new TimeSpan(20, 0, 0); // Para prube
            DateTime currentTime = DateTime.Now;
                        
            double solohora = currentTime.Hour;
            double solominuto = currentTime.Minute;
            //double solohora = 8;
            //double solominuto = 5;

            double tot_hora = solohora*60;
            double tot_min  = solominuto/60;
            
            double tot_minuto = tot_min * 100; 
            double sum = tot_hora + tot_minuto;
            double suma = sum * -1;

            Console.WriteLine(suma);

            switch (llamada)
            {
                case 1:
                    if (suma >= -480) // 8:00 am in minutes is 480
                    {
                        Console.WriteLine("1ra");
                        string asistencia = "P";
                        string tipo = "Entrada";
                        descuento = 0;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo,asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "1ra LLamada";
                    }
                    else if (suma >= -490) // 8:05 am in minutes is 485
                    {
                        string asistencia = "T";
                        string tipo = "Entrada";
                        descuento = 5;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "1ra LLamada";
                    }
                    else
                    {
                        Console.WriteLine("F");
                        string asistencia = "F";
                        string tipo = "Entrada";
                        descuento = 20;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "1ra LLamada";
                    }
                    break;

                case 2:
                    if (suma >= -720) // 12:00 am in minutes is 480
                    {
                        Console.WriteLine("1ra");
                        string asistencia = "P";
                        string tipo = "Entrada";
                        descuento = 0;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "2da LLamada";
                    }
                    else if (suma >= -730) // 12:05 am in minutes is 485
                    {
                        string asistencia = "T";
                        string tipo = "Entrada";
                        descuento = 5;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "2da LLamada";
                    }
                    else
                    {
                        Console.WriteLine("F");
                        string asistencia = "F";
                        string tipo = "Entrada";
                        descuento = 20;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "2da LLamada";
                    }
                    break;

                case 3:
                    if (suma >= -840) // 2:00 pm in minutes is 480
                    {
                        Console.WriteLine("1ra");
                        string asistencia = "P";
                        string tipo = "Entrada";
                        descuento = 0;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "3ra LLamada";
                    }
                    else if (suma >= -850) // 2:05 pm in minutes is 485
                    {
                        string asistencia = "T";
                        string tipo = "Entrada";
                        descuento = 5;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "3ra LLamada";
                    }
                    else
                    {
                        Console.WriteLine("F");
                        string asistencia = "F";
                        string tipo = "Entrada";
                        descuento = 20;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "3ra LLamada";
                    }
                    break;

                case 4:
                    if (suma >= -1080) // 6:00 pm in minutes is 480
                    {
                        Console.WriteLine("1ra");
                        string asistencia = "P";
                        string tipo = "Entrada";
                        descuento = 0;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "4ta LLamada";
                    }
                    else if (suma >= -1090) // 6:05 pm in minutes is 485
                    {
                        string asistencia = "T";
                        string tipo = "Entrada";
                        descuento = 5;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "4ta LLamada";
                    }
                    else
                    {
                        Console.WriteLine("F");
                        string asistencia = "F";
                        string tipo = "Entrada";
                        descuento = 20;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "4ta LLamada";
                    }
                    break;

                case 5:
                    if (suma >= -1200) // 8:00 pm in minutes is 480
                    {
                        Console.WriteLine("1ra");
                        string asistencia = "P";
                        string tipo = "Entrada";
                        descuento = 0;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "5ta LLamada";
                    }
                    else if (suma >= -1210) // 8:05 pm in minutes is 485
                    {
                        string asistencia = "T";
                        string tipo = "Entrada";
                        descuento = 5;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "5ta LLamada";
                    }
                    else
                    {
                        Console.WriteLine("F");
                        string asistencia = "F";
                        string tipo = "Entrada";
                        descuento = 20;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "5ta LLamada";
                    }
                    break;

                case 6:
                    if (suma >= -1380) // 11:00 pm in minutes is 480
                    {
                        Console.WriteLine("1ra");
                        string asistencia = "P";
                        string tipo = "Entrada";
                        descuento = 0;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "6ta LLamada";
                    }
                    else if (suma >= -1390) // 11:05 pm in minutes is 485
                    {
                        string asistencia = "T";
                        string tipo = "Entrada";
                        descuento = 5;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "6ta LLamada";
                    }
                    else
                    {
                        Console.WriteLine("F");
                        string asistencia = "F";
                        string tipo = "Entrada";
                        descuento = 20;
                        GuardarAsistencia(idpersonal.Text, periodo, llamada, fecha, hora_in, tipo, asistencia, descuento);
                        datos.lblDescuento.Text = descuento.ToString();
                        datos.lblIdpersonal.Text = idpersonal.Text;
                        datos.lblAsistencia.Text = asistencia.ToString();
                        datos.lblLlamada.Text = "6ta LLamada";
                    }
                    break;

                default:
                    break;
            }
        }

        public void GuardarAsistencia(string idpersonal, int periodo,int llamada, string  fecha,string hora_in,string tipo,string asistencia, double  descuento)
        {
            try
            {
                string sql = "INSERT INTO gonsad.asistencia_detalle VALUES (null,'" + idpersonal + "','" + periodo + "','" + llamada+ "','" + fecha + "','" + hora_in + "','" + tipo + "','" + asistencia + "','" + descuento + "');";
                MySqlCommand cmd = new MySqlCommand(sql, conn.Conectar());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Asistencia registrada satisfactoriamente");
                conn.CerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error Asistencia Ingreso: " + e.ToString());
            }
        }


        public void RegistraBitacora(string idpersonal)
        {

            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToShortTimeString();
            string tipo = "Entrada";

            try
            {
                string sql = "INSERT INTO gonsad.asistencia_bitacora VALUES (null,'" + idpersonal + "','" + fecha + "','" + hora + "','" + tipo + "',null,null);";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn.Conectar());

                cmd.ExecuteNonQuery();
                Console.WriteLine("Bitacora Registrada");

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Registro bitacora: " + e.ToString());
            }

            
        }

        public void RegistroSalidaDetalle(string idpersonal)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora_out = DateTime.Now.ToShortTimeString();
            string tipo = "Salida";
            int periodo = 1;
            int llamada = 0;
            string asistencia = "Temporal";
            double descuento = 0;
            

            //  Para el detalle Salida
            try
            {

                string sql2 = "INSERT INTO gonsad.asistencia_detalle VALUES (null,'" + idpersonal + "','" + periodo + "','" + llamada + "','" + fecha + "','" + hora_out + "','" + tipo + "','" + asistencia + "','" + descuento + "');";
                MySqlCommand cmd = new MySqlCommand(sql2, conn.Conectar());
                
                cmd.ExecuteNonQuery();
                Console.WriteLine("Detalle Salida Registrada");

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Registro detalle: " + e.ToString());
            }
            
            // Para la Bitacora
            try
            {
                string sql1 = "INSERT INTO gonsad.asistencia_bitacora VALUES (null,'" + idpersonal + "','" + fecha + "','" + hora_out + "','" + tipo + "',null,null);";
                MySqlCommand cmd = new MySqlCommand(sql1, conn.Conectar());

                cmd.ExecuteNonQuery();
                Console.WriteLine("Bitacora Registrada");

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Registro bitacora: " + e.ToString());
            }
        }

        public void RegistroSalidaTotal(string idpersonal)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora_out = DateTime.Now.ToShortTimeString();
            string tipo = "Salida";
            int periodo = 1;

            //  Para el detalle Salida
            try
            {

                string sql = "INSERT INTO gonsad.asistencia_registro VALUES (null,'" + periodo + "','" + idpersonal + "','" + fecha + "','" + hora_out + "','" + tipo + "');";
                MySqlCommand cmd = new MySqlCommand(sql, conn.Conectar());

                cmd.ExecuteNonQuery();
                Console.WriteLine("Detalle Salida Total");

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Registro detalle: " + e.ToString());
            }

        }

    }
}