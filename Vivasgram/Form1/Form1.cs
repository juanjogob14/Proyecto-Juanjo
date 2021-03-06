using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using VivasGramm;
using System.Net.NetworkInformation;

namespace Form1
{

    public partial class Form1 : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        static private string nick = "";
        static private string pass = "";
        VivasGramm.BasesDatos bd = new VivasGramm.BasesDatos();
        //VivasGramm.Chat chat = new VivasGramm.Chat();

        private delegate void DaddItem(String s);

        private void AddItem(String s)
        {
            listBox1.Items.Add(s);
        }
        public Form1()
        {
            InitializeComponent();

        }

        void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DaddItem(AddItem), streamr.ReadLine());
                }
                catch
                {
                    MessageBox.Show("Desconexion");
                    Application.Exit();
                }
            }
        }

        public bool IpValida(string ip)
        {
            bool correcto = true;

            string [] partes = ip.Split('.');
            char[] caracteres;

            for (int i = 0; i < partes.Length; i++)
            {
                caracteres = partes[i].ToCharArray();

                for (int j = 0; j < caracteres.Length; j++)
                {
                    if (!char.IsNumber(caracteres[j]))
                    {
                        correcto = false;
                    }
                }
            }



            return correcto;
        }

        public bool ComprobarPuerto(string puertoCadena)
        {
            bool correcto = true;
            int puerto = Convert.ToInt32(puertoCadena);

            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties(); TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            TcpConnectionInformation[] tcpinfo = ipGlobalProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpinfo)
            {
                if (tcpi.LocalEndPoint.Port == puerto)
                {
                    correcto = false;
                }
            }

            return correcto;
        }

        void Conectar()
        {
            try
            {
                if (IpValida(txtip.Text))
                {
                    if (ComprobarPuerto(txtpuerto.Text))
                    {
                        if (bd.ComprobarUsuarioRegistrado(txtUsuario.Text, txtPass.Text))
                        {
                            client.Connect(txtip.Text, Int32.Parse(txtpuerto.Text));
                            if (client.Connected)
                            {
                                Thread t = new Thread(Listen);

                                stream = client.GetStream();
                                streamw = new StreamWriter(stream);
                                streamr = new StreamReader(stream);

                                nick = txtUsuario.Text;

                                streamw.WriteLine(nick);
                                streamw.Flush();
                                streamw.WriteLine(pass);
                                streamw.Flush();

                                t.Start();

                                nick = txtUsuario.Text;
                                listBox1.Visible = true;
                                txtMensaje.Visible = true;
                                btnEnviar.Visible = true;
                                lblNombre.Visible = false;
                                btnConectar.Visible = false;
                                btnRegistrar.Visible = false;
                                txtUsuario.Visible = false;
                                lblWarning.Visible = false;
                                lblContrasenha.Visible = false;
                                txtPass.Visible = false;
                                lblIp.Visible = false;
                                lblPuerto.Visible = false;
                                txtip.Visible = false;
                                txtpuerto.Visible = false;
                                this.AcceptButton = btnEnviar;
                                this.Text = "Vivasgram";
                                this.txtMensaje.Focus();

                            }
                            else
                            {

                                MessageBox.Show("Servidor no Disponible");
                            }
                        }
                        else
                        {
                            lblWarning.Text = "Usuario o contraseña incorrectos.\n" +
                            "¿No está registrado?¡Presione el botón de registro!";
                        }
                    }
                    else
                    {
                        lblwport.Text = "Puerto no \n disponible";
                    }
                    
                }
                else
                {
                    lblwip.Text = "Ip incorrecta";
                }
                
                
            }
            catch (Exception ex)
            { 
                MessageBox.Show(this,"Error de conexion","Alerta",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.StartsWith(" ") || txtUsuario.Text == "")
            {
                lblWarning.Text = "Usuario no válido";
            }
            else if (txtip.Text == " " || txtpuerto.Text == " " || txtpuerto.Text.StartsWith(" ") || txtip.Text.StartsWith(" "))
            {
                lblWarning.Text = " Introduce puerto o ip validos";
            }
            else
            {   
                Conectar();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            if (txtMensaje.Text == "")
            {
                txtMensaje.Text = "Escriba un mensaje con cuerpo";
            }
            else 
            {
                streamw.WriteLine(txtMensaje.Text);
                streamw.Flush();
                txtMensaje.Clear();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (bd.UsuarioYaRegistrado(txtUsuario.Text))
            {
                lblWarning.Text = "Este usuario ya está registrado, \n" +
                    "pruebe otro nombre";
            }
            else
            {
                bd.AnhadirUsuario(txtUsuario.Text, txtPass.Text);
                lblWarning.Text = "El usuario ha sido registrado con éxito! \n" +
                                    "Ya puedes iniciar sesion";
            }
            
        }
    }
}