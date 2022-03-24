using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;



namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FrmAgregarProductoNuevo : Form
    {
      
        public FrmAgregarProductoNuevo(string a)
        {
            InitializeComponent();
            id = a;
            //En el inicializador se le asigna las credenciales del Servidor.
            cloud = new Cloudinary(A);
        }

        // se crea una variable estatica de cloudinary
        public static Cloudinary cloud;

        //Se crea una variable Account A que contendra todos las credenciales de nuestro servidor 
        Account A = new Account("cubosix", "996516874565789", "sukPe7qfN7EsZ_qE0DG1z5T87Dg");

        string id;
        string imagen;
        CLogicaObtenerIP idS = new CLogicaObtenerIP();
        CLogicaRegistrarProducto save = new CLogicaRegistrarProducto();
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgregarProductoNuevo_Load(object sender, EventArgs e)
        {
            LblIdUsuario.Text = id;
            cmbCategorias();
            cmbUnidadMedida();
        }

        private void CargarImagen(String ruta)
        {
            //metodo try para capturar los posibles errores

            try
            {

                //funcion de peticion para subir una imagen A cloudinari
                var uploadParams = new ImageUploadParams()
                {
                    //se el apsa la ruta de la ubicacion del archivo.
                    File = new FileDescription(ruta)
                };

                //Funcion que obtiene resultado del la subida .
                var uploadResult = cloud.Upload(uploadParams);

                ruta = uploadResult.SecureUri.ToString();
                MessageBox.Show("Imagen subida correctamente al servidor cloudinary");

                

                MessageBox.Show(@"" + ruta);
                imagen = ruta;
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        void CapturarDatos()
        {
            string nom = TxtNombreProducto.Text;
            int IdUnidadM = Convert.ToInt32(CmbUnidadMedida.SelectedValue.ToString());
            string descrip = TxtDescripcion.Text;
            string marca = TxtMarca.Text;
            int IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());

            CLogicaConsultas c = new CLogicaConsultas();
            CLogicaObtenerIP b = new CLogicaObtenerIP();
            string localIP = b.ObtenerIp();

            MessageBox.Show("Local Ip = " + localIP);

            string idU = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina.IpMaquina = '" + localIP + "'");
            string IdSede = c.ConsultaSimple("SELECT Usuarios.IdSede FROM Usuarios WHERE Usuarios.IdUsuario = '" + idU + "'");

            string result = save.AgregarProductos(nom,descrip,marca,0,IdUnidadM,IdCategoria,Convert.ToInt32(IdSede), imagen);


            MessageBox.Show("Res = " + result);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MetodoValidar() == 3)
            {
                if (imagen != "")
                {
                    CapturarDatos();
                    CargarImagen(imagen);
                }
                else
                {
                    MessageBox.Show("Porfavor verifique la imagen seleccionada");
                }
  
            }
            else
            {
                MessageBox.Show("Uno o más campos se encuentran vacíos. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void TxtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }


        void cmbCategorias()
        {
            CmbCategoria.DataSource = fill.cmbCategoria();
            CmbCategoria.DisplayMember = "DescripcionC";
            CmbCategoria.ValueMember = "IdCategoria";

        }

        void cmbUnidadMedida()
        {
            CmbUnidadMedida.DataSource = fill.cmbUnidadM();
            CmbUnidadMedida.DisplayMember = "DescripcionTipoUM";
            CmbUnidadMedida.ValueMember = "IdUnidadM";

        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSelectorImagen = new OpenFileDialog();

            if (ofdSelectorImagen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PtbImagen.Image = Image.FromFile(ofdSelectorImagen.FileName);
            }

            imagen = ofdSelectorImagen.FileName.ToString();
            imagen = imagen.Replace('\\', '/');
        }


        //METODO PARA LIMPIAR LOS CAMPOS 
        void Detele()
        {
            TxtNombreProducto.Text = "";
            TxtMarca.Text = "";
            TxtDescripcion.Text = "";
            CmbUnidadMedida.SelectedValue = 1;
            CmbCategoria.SelectedValue = 1;
        }

        //METODO PARA VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        int MetodoValidar()
        {
            int validation = 0;
            if (TxtNombreProducto.Text != "")
                validation++;

            else
                validation--;

            if (TxtDescripcion.Text != "")
                validation++;

            else
                validation--;

            if (TxtMarca.Text != "")
                validation++;
            else
                validation--;

            if (validation < 0)
                validation = 0;
            return validation;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Detele();
        }
    }
}
