using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IntegraJeff
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Hilo usado para el subproceso en segundo plano.
        /// </summary>
        Thread hilo;

        /// <summary>
        /// Action usado para el hilo.
        /// </summary>
        Action act;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se establece la accion en el Action
            act = () =>
            {
                //Esta la capa de sub-red
                string subnet = "192.168.0";

                //Se hace un bucle for donde se escanean todas las direcciones
                for (int i = 2; i < 255; i++)
                {
                    //Se hace la direccion ip, añadiendo a la capa subred la iteracion i.
                    string ip = $"{subnet}.{i}";
                    try
                    {
                        //Se hace una llamada de ping de datos para validar que existe esa ip.
                        Ping actping = new Ping();
                        //Se le coloca un timer de 100 milisegundos para no malgastar tiempo
                        PingReply reply = actping.Send(ip, 100);

                        //Este if es para confirmar si la comunicación fue exitosa
                        if (reply.Status == IPStatus.Success)
                        {
                            //Se usa el Invoke del control del combo box de direcciones para agregarlas a este.
                            cboDirecciones.BeginInvoke(new Action(() =>
                            {

                                try
                                {
                                    //Esto era para comprobar una entrada DNS pero retrasa la operacion
                                    //IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));

                                    //Se añade la direccion al combo box
                                    cboDirecciones.Items.Add(ip);
                                }
                                catch (Exception ex)
                                {
                                    //MessageBox.Show(ex.Message);
                                }
                                //pgbBarraProgreso.Value++;
                            }));


                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                MessageBox.Show("Finalizo el escaneo");
            };
            //Se instancia un hilo y se le agrega el action
            hilo = new Thread(new ThreadStart(act));

            //Se incia el hilo
            hilo.Start();

            #region EstaIP
            //Esta seccion se usa para visualizar la ip de este ordenador.
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            lblDireccion.Text = localIP;
            #endregion
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se usa el primer configurar ya que se establece la direccion
                ConexionBD.Configurar(cboDirecciones.Text, "integrajeffschm", "ingreuser", "ingreuser");

                Registro reg = new Registro();
                //Se instancia un login
                Login lgInicio = new Login(reg);
                reg.Log = lgInicio;

                //Se esconde esta ventana. Nota: Aun esta activa solo esta escondida o Invisible
                this.Hide();

                //Se fiinaliza el hilo ya que se concreto el proceso.
                hilo.Abort();

                //Se muestra la nueva ventana
                lgInicio.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se cancela el hilo.
            hilo.Abort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
