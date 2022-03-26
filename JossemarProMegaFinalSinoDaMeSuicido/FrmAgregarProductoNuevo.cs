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
using ImageMagick;


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
            BtnAñadir.Enabled = false;
            BtnGuardar.Enabled = false;
        }

        // se crea una variable estatica de cloudinary
        public static Cloudinary cloud;

        //Se crea una variable Account A que contendra todos las credenciales de nuestro servidor 
        Account A = new Account("cubosix", "996516874565789", "sukPe7qfN7EsZ_qE0DG1z5T87Dg");

        CLogicaConsultas sql = new CLogicaConsultas();
        string id;
        string imagen;
        string imagen2;
        string rutaGuardar;
        int contador = 0;
        int contador2 = 0;

    
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
                //MessageBox.Show("Imagen subida correctamente al servidor cloudinary");

                //MessageBox.Show(@"" + ruta);
                imagen = ruta;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void Limpiar2()
        {
            contador2--;
            foreach (DataGridViewRow row in DgvCarrito.SelectedRows)
            {
                DgvCarrito.Rows.RemoveAt(row.Index);
            }
            contador2 = 0;
        }

        void CapturarDatos()
        {
            //string nom = TxtNombreProducto.Text;
            //int IdUnidadM = Convert.ToInt32(CmbUnidadMedida2.SelectedValue.ToString());
            //string descrip = TxtDescripcion.Text;
            //string marca = TxtMarca.Text;
            //int IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());

            //  MessageBox.Show("Local Ip = " + localIP);
            contador = DgvCarrito.Rows.Count;
            for (int i = 0; i < contador; i++)
            {

                CLogicaConsultas c = new CLogicaConsultas();
                CLogicaObtenerIP b = new CLogicaObtenerIP();
                string localIP = b.ObtenerIp();

                string idU = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina.IpMaquina = '" + localIP + "'");
                string IdSede = c.ConsultaSimple("SELECT Usuarios.IdSede FROM Usuarios WHERE Usuarios.IdUsuario = '" + idU + "'");


                //Obtenemos los ID de los combobox para pasarlos como parametros

                string nom = Convert.ToString(DgvCarrito.Rows[i].Cells[1].Value).Trim();
                string descrip = Convert.ToString(DgvCarrito.Rows[i].Cells[5].Value).Trim();
                string marca = Convert.ToString(DgvCarrito.Rows[i].Cells[2].Value);
                int IdUnidadM = Convert.ToInt32(DgvCarrito.Rows[i].Cells[7].Value);
                int IdCategoria = Convert.ToInt32(DgvCarrito.Rows[i].Cells[6].Value);
                imagen = Convert.ToString(DgvCarrito.Rows[i].Cells[8].Value).Trim();

                CargarImagen(imagen);

                string result = save.AgregarProductos(nom, descrip, marca, 0, IdUnidadM, IdCategoria, Convert.ToInt32(IdSede), imagen);



                //MessageBox.Show("Vuelta Numero"+i);
            }

            Limpiar2();


            //MessageBox.Show("Res = " + result);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            Limpiar2();

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
            CmbUnidadMedida2.DataSource = fill.cmbUnidadM();
            CmbUnidadMedida2.DisplayMember = "DescripcionTipoUM";
            CmbUnidadMedida2.ValueMember = "IdUnidadM";

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
            rutaGuardar = imagen;


        }


        //METODO PARA LIMPIAR LOS CAMPOS 
        void Detele()
        {
            TxtNombreProducto.Text = "";
            TxtMarca.Text = "";
            TxtDescripcion.Text = "";
            CmbUnidadMedida2.SelectedValue = 1;
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
            BtnAñadir.Enabled = false;
        }

        void AñadirDatosAlCarrito()
        {
            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCarrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            contador = 0 + contador2;
            contador2++;
            DgvCarrito.Rows.Add();

            TxtTotalCompra.Text = Convert.ToString(contador2);



            DgvCarrito.Rows[contador].Cells[0].Value = imagen2.ToString();
            DgvCarrito.Rows[contador].Cells[1].Value = TxtNombreProducto.Text;
            DgvCarrito.Rows[contador].Cells[2].Value = TxtMarca.Text;


            int Categoria = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());
            string categoriaa = sql.ConsultaSimple("SELECT DescripcionC as Categoria, IdCategoria as ID FROM Categoria where IdCategoria  = '" + Categoria + "'");
            DgvCarrito.Rows[contador].Cells[3].Value = categoriaa;
            DgvCarrito.Rows[contador].Cells[6].Value = Convert.ToInt32(CmbCategoria.SelectedValue.ToString());

            int UnidadMedida = Convert.ToInt32(CmbUnidadMedida2.SelectedValue.ToString());
            string medidaa = sql.ConsultaSimple("SELECT  DescripcionTipoUM as Medida, IdUnidadM as ID FROM UnidadMedidas where IdUnidadM  = '" + UnidadMedida + "'");
            DgvCarrito.Rows[contador].Cells[4].Value = medidaa;
            DgvCarrito.Rows[contador].Cells[7].Value = Convert.ToInt32(CmbUnidadMedida2.SelectedValue.ToString());

            DgvCarrito.Rows[contador].Cells[5].Value = TxtDescripcion.Text;
            DgvCarrito.Rows[contador].Cells[8].Value = rutaGuardar;

        }

        private void DgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PnlBarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvCarrito_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.DgvCarrito.Columns[e.ColumnIndex].Name)
            {
                case "CIMAGEN":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {

                            e.Value = null;
                        }
                    }
                    break;
            }
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            AñadirDatosAlCarrito();
            BtnAjustar.Enabled = true;
        }

        private void BtnAjustar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Especifique una ruta para guardar la nueva imagen");

            //Abrimos cuadro de dialogo para seleccionar ruta de guardado
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //Con esto seleccionamos la ruta en forma de string
                TxtNuevaImagen.Text = dlg.SelectedPath;
                BtnAjustar.Enabled = true;
            }

            if (TxtNuevaImagen.Text == string.Empty)
            {
                MessageBox.Show("Por favor Ponga una ruta :)");
            }
            else
            {
                try
                {

                    //Con esto seleccionamos la imagen a rediseñar
                    using (MagickImage rediseño = new MagickImage(imagen))
                    {
                        //Cambiamos el tamaño
                        rediseño.Resize(150, 150);

                        //Nombre del archivo a guardar
                        string nombre_copia = "ImagenModificada" + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString();

                        //Variable donde se guardara la nueva imagen con su ubicacion y su nombre
                        //el nombre y el formato de guardado son editables a criterio propio
                        imagen2 = @"" + TxtNuevaImagen.Text + "\\" + nombre_copia + ".jpg";

                        //Con esto sobreescribimos en la varible y guardamos todo
                        rediseño.Write(imagen2);
                        BtnAjustar.Enabled = false;
                        BtnAñadir.Enabled = true;
                        BtnGuardar.Enabled = true;
                        //imagen2 = "";

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }

        }
        }
    }

