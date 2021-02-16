
namespace LVAPV07
{
    partial class frmAsignacionPractica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatospersonales = new System.Windows.Forms.GroupBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.grpFotografia = new System.Windows.Forms.GroupBox();
            this.picFotografia = new System.Windows.Forms.PictureBox();
            this.grpDatoscarrera = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblApellidomaterno = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTelfofnomovil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidopataerno = new System.Windows.Forms.TextBox();
            this.txtApellidomaterno = new System.Windows.Forms.TextBox();
            this.txtTelefonofijo = new System.Windows.Forms.TextBox();
            this.txtTelefonomovil = new System.Windows.Forms.TextBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.rdbE = new System.Windows.Forms.RadioButton();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.grpDocumentos = new System.Windows.Forms.GroupBox();
            this.chkSolicituddepracticas = new System.Windows.Forms.CheckBox();
            this.chkCartacompromiso = new System.Windows.Forms.CheckBox();
            this.chkCurriculum = new System.Windows.Forms.CheckBox();
            this.chkEntrevistaporcompetecncias = new System.Windows.Forms.CheckBox();
            this.chkSeleccionempresa = new System.Windows.Forms.CheckBox();
            this.chkCartaaceptacuion = new System.Windows.Forms.CheckBox();
            this.chkSegurogatosmedicos = new System.Windows.Forms.CheckBox();
            this.chlCartapresentacion = new System.Windows.Forms.CheckBox();
            this.chkCartalibreación = new System.Windows.Forms.CheckBox();
            this.chkServiciosocial = new System.Windows.Forms.CheckBox();
            this.grpDatosempresa = new System.Windows.Forms.GroupBox();
            this.cbmCarrera = new System.Windows.Forms.ComboBox();
            this.pmbSemestre = new System.Windows.Forms.ComboBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lstDatosempresa = new System.Windows.Forms.ListBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblAscersor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefonomovilasesor = new System.Windows.Forms.Label();
            this.txtTelefonoasesor = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblFechaincio = new System.Windows.Forms.Label();
            this.lblFechaterminoi = new System.Windows.Forms.Label();
            this.dtpFechainicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechatermino = new System.Windows.Forms.DateTimePicker();
            this.grpDatospersonales.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.grpFotografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).BeginInit();
            this.grpDatoscarrera.SuspendLayout();
            this.grpDocumentos.SuspendLayout();
            this.grpDatosempresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatospersonales
            // 
            this.grpDatospersonales.Controls.Add(this.txtTelefonomovil);
            this.grpDatospersonales.Controls.Add(this.txtTelefonofijo);
            this.grpDatospersonales.Controls.Add(this.txtApellidomaterno);
            this.grpDatospersonales.Controls.Add(this.txtApellidopataerno);
            this.grpDatospersonales.Controls.Add(this.txtNombre);
            this.grpDatospersonales.Controls.Add(this.lblTelfofnomovil);
            this.grpDatospersonales.Controls.Add(this.lblTelefono);
            this.grpDatospersonales.Controls.Add(this.lblApellidomaterno);
            this.grpDatospersonales.Controls.Add(this.lblApellido);
            this.grpDatospersonales.Controls.Add(this.lblName);
            this.grpDatospersonales.Location = new System.Drawing.Point(12, 12);
            this.grpDatospersonales.Name = "grpDatospersonales";
            this.grpDatospersonales.Size = new System.Drawing.Size(517, 159);
            this.grpDatospersonales.TabIndex = 0;
            this.grpDatospersonales.TabStop = false;
            this.grpDatospersonales.Text = "Datos Personales ";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbF);
            this.grpGenero.Controls.Add(this.rdbM);
            this.grpGenero.Location = new System.Drawing.Point(535, 12);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(96, 73);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            this.grpGenero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdbE);
            this.grpTipo.Controls.Add(this.rdbN);
            this.grpTipo.Location = new System.Drawing.Point(535, 91);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(96, 80);
            this.grpTipo.TabIndex = 2;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // grpFotografia
            // 
            this.grpFotografia.Controls.Add(this.picFotografia);
            this.grpFotografia.Location = new System.Drawing.Point(637, 12);
            this.grpFotografia.Name = "grpFotografia";
            this.grpFotografia.Size = new System.Drawing.Size(133, 159);
            this.grpFotografia.TabIndex = 3;
            this.grpFotografia.TabStop = false;
            this.grpFotografia.Text = "Foyografía ";
            // 
            // picFotografia
            // 
            this.picFotografia.Image = global::LVAPV07.Properties.Resources.WhatsApp_Image_2021_02_13_at_3_04_43_PM;
            this.picFotografia.Location = new System.Drawing.Point(6, 19);
            this.picFotografia.Name = "picFotografia";
            this.picFotografia.Size = new System.Drawing.Size(122, 140);
            this.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotografia.TabIndex = 0;
            this.picFotografia.TabStop = false;
            // 
            // grpDatoscarrera
            // 
            this.grpDatoscarrera.Controls.Add(this.txtPromedio);
            this.grpDatoscarrera.Controls.Add(this.pmbSemestre);
            this.grpDatoscarrera.Controls.Add(this.cbmCarrera);
            this.grpDatoscarrera.Controls.Add(this.chkServiciosocial);
            this.grpDatoscarrera.Controls.Add(this.lblPromedio);
            this.grpDatoscarrera.Controls.Add(this.lblSemestre);
            this.grpDatoscarrera.Controls.Add(this.lblCarrera);
            this.grpDatoscarrera.Location = new System.Drawing.Point(12, 177);
            this.grpDatoscarrera.Name = "grpDatoscarrera";
            this.grpDatoscarrera.Size = new System.Drawing.Size(751, 111);
            this.grpDatoscarrera.TabIndex = 4;
            this.grpDatoscarrera.TabStop = false;
            this.grpDatoscarrera.Text = "Datos Carerra ";
            this.grpDatoscarrera.Enter += new System.EventHandler(this.grpDatoscarrera_Enter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(0, 43);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(87, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido Paterno:";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblApellidomaterno
            // 
            this.lblApellidomaterno.AutoSize = true;
            this.lblApellidomaterno.Location = new System.Drawing.Point(-3, 70);
            this.lblApellidomaterno.Name = "lblApellidomaterno";
            this.lblApellidomaterno.Size = new System.Drawing.Size(86, 13);
            this.lblApellidomaterno.TabIndex = 2;
            this.lblApellidomaterno.Text = "Apellido Materno";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(0, 98);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Télefono Fijo:";
            // 
            // lblTelfofnomovil
            // 
            this.lblTelfofnomovil.AutoSize = true;
            this.lblTelfofnomovil.Location = new System.Drawing.Point(0, 127);
            this.lblTelfofnomovil.Name = "lblTelfofnomovil";
            this.lblTelfofnomovil.Size = new System.Drawing.Size(80, 13);
            this.lblTelfofnomovil.TabIndex = 4;
            this.lblTelfofnomovil.Text = "Télefono Móvil:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(404, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellidopataerno
            // 
            this.txtApellidopataerno.Location = new System.Drawing.Point(93, 44);
            this.txtApellidopataerno.Name = "txtApellidopataerno";
            this.txtApellidopataerno.Size = new System.Drawing.Size(404, 20);
            this.txtApellidopataerno.TabIndex = 6;
            // 
            // txtApellidomaterno
            // 
            this.txtApellidomaterno.Location = new System.Drawing.Point(93, 70);
            this.txtApellidomaterno.Name = "txtApellidomaterno";
            this.txtApellidomaterno.Size = new System.Drawing.Size(404, 20);
            this.txtApellidomaterno.TabIndex = 7;
            // 
            // txtTelefonofijo
            // 
            this.txtTelefonofijo.Location = new System.Drawing.Point(93, 95);
            this.txtTelefonofijo.Name = "txtTelefonofijo";
            this.txtTelefonofijo.Size = new System.Drawing.Size(404, 20);
            this.txtTelefonofijo.TabIndex = 8;
            // 
            // txtTelefonomovil
            // 
            this.txtTelefonomovil.Location = new System.Drawing.Point(93, 124);
            this.txtTelefonomovil.Name = "txtTelefonomovil";
            this.txtTelefonomovil.Size = new System.Drawing.Size(404, 20);
            this.txtTelefonomovil.TabIndex = 9;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(7, 21);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(7, 46);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 17);
            this.rdbF.TabIndex = 1;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            this.rdbF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.Location = new System.Drawing.Point(7, 20);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(33, 17);
            this.rdbN.TabIndex = 0;
            this.rdbN.TabStop = true;
            this.rdbN.Text = "N";
            this.rdbN.UseVisualStyleBackColor = true;
            // 
            // rdbE
            // 
            this.rdbE.AutoSize = true;
            this.rdbE.Location = new System.Drawing.Point(7, 44);
            this.rdbE.Name = "rdbE";
            this.rdbE.Size = new System.Drawing.Size(32, 17);
            this.rdbE.TabIndex = 1;
            this.rdbE.TabStop = true;
            this.rdbE.Text = "E";
            this.rdbE.UseVisualStyleBackColor = true;
            this.rdbE.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(3, 25);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 10;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(0, 48);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(54, 13);
            this.lblSemestre.TabIndex = 11;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(0, 81);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 12;
            this.lblPromedio.Text = "Promedio:";
            // 
            // grpDocumentos
            // 
            this.grpDocumentos.Controls.Add(this.chkCartalibreación);
            this.grpDocumentos.Controls.Add(this.chlCartapresentacion);
            this.grpDocumentos.Controls.Add(this.chkSegurogatosmedicos);
            this.grpDocumentos.Controls.Add(this.chkCartaaceptacuion);
            this.grpDocumentos.Controls.Add(this.chkSeleccionempresa);
            this.grpDocumentos.Controls.Add(this.chkEntrevistaporcompetecncias);
            this.grpDocumentos.Controls.Add(this.chkCurriculum);
            this.grpDocumentos.Controls.Add(this.chkCartacompromiso);
            this.grpDocumentos.Controls.Add(this.chkSolicituddepracticas);
            this.grpDocumentos.Location = new System.Drawing.Point(15, 294);
            this.grpDocumentos.Name = "grpDocumentos";
            this.grpDocumentos.Size = new System.Drawing.Size(750, 99);
            this.grpDocumentos.TabIndex = 5;
            this.grpDocumentos.TabStop = false;
            this.grpDocumentos.Text = "Documentos Entregados ";
            // 
            // chkSolicituddepracticas
            // 
            this.chkSolicituddepracticas.AutoSize = true;
            this.chkSolicituddepracticas.Location = new System.Drawing.Point(3, 20);
            this.chkSolicituddepracticas.Name = "chkSolicituddepracticas";
            this.chkSolicituddepracticas.Size = new System.Drawing.Size(177, 17);
            this.chkSolicituddepracticas.TabIndex = 0;
            this.chkSolicituddepracticas.Text = "Solicitud prácticas profesionales";
            this.chkSolicituddepracticas.UseVisualStyleBackColor = true;
            // 
            // chkCartacompromiso
            // 
            this.chkCartacompromiso.AutoSize = true;
            this.chkCartacompromiso.Location = new System.Drawing.Point(6, 43);
            this.chkCartacompromiso.Name = "chkCartacompromiso";
            this.chkCartacompromiso.Size = new System.Drawing.Size(110, 17);
            this.chkCartacompromiso.TabIndex = 1;
            this.chkCartacompromiso.Text = "Carta compromiso";
            this.chkCartacompromiso.UseVisualStyleBackColor = true;
            // 
            // chkCurriculum
            // 
            this.chkCurriculum.AutoSize = true;
            this.chkCurriculum.Location = new System.Drawing.Point(6, 66);
            this.chkCurriculum.Name = "chkCurriculum";
            this.chkCurriculum.Size = new System.Drawing.Size(75, 17);
            this.chkCurriculum.TabIndex = 2;
            this.chkCurriculum.Text = "Curriculum";
            this.chkCurriculum.UseVisualStyleBackColor = true;
            // 
            // chkEntrevistaporcompetecncias
            // 
            this.chkEntrevistaporcompetecncias.AutoSize = true;
            this.chkEntrevistaporcompetecncias.Location = new System.Drawing.Point(298, 20);
            this.chkEntrevistaporcompetecncias.Name = "chkEntrevistaporcompetecncias";
            this.chkEntrevistaporcompetecncias.Size = new System.Drawing.Size(163, 17);
            this.chkEntrevistaporcompetecncias.TabIndex = 3;
            this.chkEntrevistaporcompetecncias.Text = "Entrevista por competencias ";
            this.chkEntrevistaporcompetecncias.UseVisualStyleBackColor = true;
            this.chkEntrevistaporcompetecncias.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkSeleccionempresa
            // 
            this.chkSeleccionempresa.AutoSize = true;
            this.chkSeleccionempresa.Location = new System.Drawing.Point(298, 43);
            this.chkSeleccionempresa.Name = "chkSeleccionempresa";
            this.chkSeleccionempresa.Size = new System.Drawing.Size(132, 17);
            this.chkSeleccionempresa.TabIndex = 4;
            this.chkSeleccionempresa.Text = "Selección de Empresa";
            this.chkSeleccionempresa.UseVisualStyleBackColor = true;
            // 
            // chkCartaaceptacuion
            // 
            this.chkCartaaceptacuion.AutoSize = true;
            this.chkCartaaceptacuion.Location = new System.Drawing.Point(298, 66);
            this.chkCartaaceptacuion.Name = "chkCartaaceptacuion";
            this.chkCartaaceptacuion.Size = new System.Drawing.Size(123, 17);
            this.chkCartaaceptacuion.TabIndex = 5;
            this.chkCartaaceptacuion.Text = "Carta de Aceptación";
            this.chkCartaaceptacuion.UseVisualStyleBackColor = true;
            // 
            // chkSegurogatosmedicos
            // 
            this.chkSegurogatosmedicos.AutoSize = true;
            this.chkSegurogatosmedicos.Location = new System.Drawing.Point(583, 20);
            this.chkSegurogatosmedicos.Name = "chkSegurogatosmedicos";
            this.chkSegurogatosmedicos.Size = new System.Drawing.Size(154, 17);
            this.chkSegurogatosmedicos.TabIndex = 6;
            this.chkSegurogatosmedicos.Text = "Seguro de Gastos Médicos";
            this.chkSegurogatosmedicos.UseVisualStyleBackColor = true;
            this.chkSegurogatosmedicos.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // chlCartapresentacion
            // 
            this.chlCartapresentacion.AutoSize = true;
            this.chlCartapresentacion.Location = new System.Drawing.Point(583, 43);
            this.chlCartapresentacion.Name = "chlCartapresentacion";
            this.chlCartapresentacion.Size = new System.Drawing.Size(125, 17);
            this.chlCartapresentacion.TabIndex = 7;
            this.chlCartapresentacion.Text = "Carta de preentación";
            this.chlCartapresentacion.UseVisualStyleBackColor = true;
            // 
            // chkCartalibreación
            // 
            this.chkCartalibreación.AutoSize = true;
            this.chkCartalibreación.Location = new System.Drawing.Point(583, 66);
            this.chkCartalibreación.Name = "chkCartalibreación";
            this.chkCartalibreación.Size = new System.Drawing.Size(114, 17);
            this.chkCartalibreación.TabIndex = 8;
            this.chkCartalibreación.Text = "Crata de liberación";
            this.chkCartalibreación.UseVisualStyleBackColor = true;
            // 
            // chkServiciosocial
            // 
            this.chkServiciosocial.AutoSize = true;
            this.chkServiciosocial.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkServiciosocial.Location = new System.Drawing.Point(589, 88);
            this.chkServiciosocial.Name = "chkServiciosocial";
            this.chkServiciosocial.Size = new System.Drawing.Size(151, 17);
            this.chkServiciosocial.TabIndex = 14;
            this.chkServiciosocial.Text = "Servicio Social Conlcuidos";
            this.chkServiciosocial.UseVisualStyleBackColor = true;
            // 
            // grpDatosempresa
            // 
            this.grpDatosempresa.Controls.Add(this.dtpFechatermino);
            this.grpDatosempresa.Controls.Add(this.dtpFechainicio);
            this.grpDatosempresa.Controls.Add(this.lblFechaterminoi);
            this.grpDatosempresa.Controls.Add(this.lblFechaincio);
            this.grpDatosempresa.Controls.Add(this.txtContacto);
            this.grpDatosempresa.Controls.Add(this.txtAsesor);
            this.grpDatosempresa.Controls.Add(this.txtEmail);
            this.grpDatosempresa.Controls.Add(this.txtTelefonoasesor);
            this.grpDatosempresa.Controls.Add(this.lblTelefonomovilasesor);
            this.grpDatosempresa.Controls.Add(this.lblEmail);
            this.grpDatosempresa.Controls.Add(this.lblAscersor);
            this.grpDatosempresa.Controls.Add(this.lblContacto);
            this.grpDatosempresa.Controls.Add(this.lstDatosempresa);
            this.grpDatosempresa.Location = new System.Drawing.Point(15, 399);
            this.grpDatosempresa.Name = "grpDatosempresa";
            this.grpDatosempresa.Size = new System.Drawing.Size(748, 205);
            this.grpDatosempresa.TabIndex = 6;
            this.grpDatosempresa.TabStop = false;
            this.grpDatosempresa.Text = "Datos Empresa";
            // 
            // cbmCarrera
            // 
            this.cbmCarrera.FormattingEnabled = true;
            this.cbmCarrera.Items.AddRange(new object[] {
            "Ingenieria de Software",
            "Ingenieria Quimica ",
            "Licenciatura en Administracion Empresarial",
            "Licenciatura en Gastronomia ",
            "Ingenieria Industrial",
            "Fisica",
            "Arquitectura",
            "Ingenieria en Logistica "});
            this.cbmCarrera.Location = new System.Drawing.Point(93, 19);
            this.cbmCarrera.Name = "cbmCarrera";
            this.cbmCarrera.Size = new System.Drawing.Size(647, 21);
            this.cbmCarrera.TabIndex = 0;
            // 
            // pmbSemestre
            // 
            this.pmbSemestre.FormattingEnabled = true;
            this.pmbSemestre.Items.AddRange(new object[] {
            "1er Semestre",
            "2do Semestre",
            "3er Semestre",
            "4to Semestre",
            "5to Semestre",
            "6to Semestre",
            "7mo Semestre",
            "8vo Semestre"});
            this.pmbSemestre.Location = new System.Drawing.Point(93, 50);
            this.pmbSemestre.Name = "pmbSemestre";
            this.pmbSemestre.Size = new System.Drawing.Size(647, 21);
            this.pmbSemestre.TabIndex = 15;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(93, 78);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(181, 20);
            this.txtPromedio.TabIndex = 10;
            // 
            // lstDatosempresa
            // 
            this.lstDatosempresa.FormattingEnabled = true;
            this.lstDatosempresa.Items.AddRange(new object[] {
            "T-System",
            "VW",
            "BMW",
            "Sysne",
            "GM",
            "Google",
            "SDR",
            "MexAbat",
            "AWS",
            "Benteler",
            "Safrán",
            "IBM",
            "Audi",
            "Cisco"});
            this.lstDatosempresa.Location = new System.Drawing.Point(6, 28);
            this.lstDatosempresa.Name = "lstDatosempresa";
            this.lstDatosempresa.Size = new System.Drawing.Size(136, 173);
            this.lstDatosempresa.TabIndex = 0;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(295, 28);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(53, 13);
            this.lblContacto.TabIndex = 16;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblAscersor
            // 
            this.lblAscersor.AutoSize = true;
            this.lblAscersor.Location = new System.Drawing.Point(295, 53);
            this.lblAscersor.Name = "lblAscersor";
            this.lblAscersor.Size = new System.Drawing.Size(42, 13);
            this.lblAscersor.TabIndex = 17;
            this.lblAscersor.Text = "Asesor:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(295, 81);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefonomovilasesor
            // 
            this.lblTelefonomovilasesor.AutoSize = true;
            this.lblTelefonomovilasesor.Location = new System.Drawing.Point(295, 103);
            this.lblTelefonomovilasesor.Name = "lblTelefonomovilasesor";
            this.lblTelefonomovilasesor.Size = new System.Drawing.Size(115, 13);
            this.lblTelefonomovilasesor.TabIndex = 19;
            this.lblTelefonomovilasesor.Text = "Télefono Movil Asesor:";
            // 
            // txtTelefonoasesor
            // 
            this.txtTelefonoasesor.Location = new System.Drawing.Point(413, 100);
            this.txtTelefonoasesor.Name = "txtTelefonoasesor";
            this.txtTelefonoasesor.Size = new System.Drawing.Size(324, 20);
            this.txtTelefonoasesor.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(413, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtAsesor
            // 
            this.txtAsesor.Location = new System.Drawing.Point(413, 45);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.Size = new System.Drawing.Size(324, 20);
            this.txtAsesor.TabIndex = 21;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(413, 19);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(324, 20);
            this.txtContacto.TabIndex = 22;
            // 
            // lblFechaincio
            // 
            this.lblFechaincio.AutoSize = true;
            this.lblFechaincio.Location = new System.Drawing.Point(461, 144);
            this.lblFechaincio.Name = "lblFechaincio";
            this.lblFechaincio.Size = new System.Drawing.Size(67, 13);
            this.lblFechaincio.TabIndex = 23;
            this.lblFechaincio.Text = "Fecha inicio:";
            // 
            // lblFechaterminoi
            // 
            this.lblFechaterminoi.AutoSize = true;
            this.lblFechaterminoi.Location = new System.Drawing.Point(447, 176);
            this.lblFechaterminoi.Name = "lblFechaterminoi";
            this.lblFechaterminoi.Size = new System.Drawing.Size(81, 13);
            this.lblFechaterminoi.TabIndex = 26;
            this.lblFechaterminoi.Text = "Fecha Termino:";
            this.lblFechaterminoi.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechainicio
            // 
            this.dtpFechainicio.Location = new System.Drawing.Point(542, 144);
            this.dtpFechainicio.Name = "dtpFechainicio";
            this.dtpFechainicio.Size = new System.Drawing.Size(195, 20);
            this.dtpFechainicio.TabIndex = 27;
            // 
            // dtpFechatermino
            // 
            this.dtpFechatermino.Location = new System.Drawing.Point(542, 170);
            this.dtpFechatermino.Name = "dtpFechatermino";
            this.dtpFechatermino.Size = new System.Drawing.Size(200, 20);
            this.dtpFechatermino.TabIndex = 28;
            // 
            // frmAsignacionPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 616);
            this.Controls.Add(this.grpDatosempresa);
            this.Controls.Add(this.grpDocumentos);
            this.Controls.Add(this.grpDatoscarrera);
            this.Controls.Add(this.grpFotografia);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDatospersonales);
            this.Name = "frmAsignacionPractica";
            this.Text = "Asignación Practica Profesional ";
            this.grpDatospersonales.ResumeLayout(false);
            this.grpDatospersonales.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpFotografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).EndInit();
            this.grpDatoscarrera.ResumeLayout(false);
            this.grpDatoscarrera.PerformLayout();
            this.grpDocumentos.ResumeLayout(false);
            this.grpDocumentos.PerformLayout();
            this.grpDatosempresa.ResumeLayout(false);
            this.grpDatosempresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatospersonales;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.GroupBox grpFotografia;
        private System.Windows.Forms.Label lblApellidomaterno;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picFotografia;
        private System.Windows.Forms.GroupBox grpDatoscarrera;
        private System.Windows.Forms.TextBox txtApellidopataerno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelfofnomovil;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefonomovil;
        private System.Windows.Forms.TextBox txtTelefonofijo;
        private System.Windows.Forms.TextBox txtApellidomaterno;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbE;
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.GroupBox grpDocumentos;
        private System.Windows.Forms.CheckBox chkCartalibreación;
        private System.Windows.Forms.CheckBox chlCartapresentacion;
        private System.Windows.Forms.CheckBox chkSegurogatosmedicos;
        private System.Windows.Forms.CheckBox chkCartaaceptacuion;
        private System.Windows.Forms.CheckBox chkSeleccionempresa;
        private System.Windows.Forms.CheckBox chkEntrevistaporcompetecncias;
        private System.Windows.Forms.CheckBox chkCurriculum;
        private System.Windows.Forms.CheckBox chkCartacompromiso;
        private System.Windows.Forms.CheckBox chkSolicituddepracticas;
        private System.Windows.Forms.CheckBox chkServiciosocial;
        private System.Windows.Forms.GroupBox grpDatosempresa;
        private System.Windows.Forms.ComboBox cbmCarrera;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.ComboBox pmbSemestre;
        private System.Windows.Forms.Label lblFechaterminoi;
        private System.Windows.Forms.Label lblFechaincio;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefonoasesor;
        private System.Windows.Forms.Label lblTelefonomovilasesor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAscersor;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.ListBox lstDatosempresa;
        private System.Windows.Forms.DateTimePicker dtpFechatermino;
        private System.Windows.Forms.DateTimePicker dtpFechainicio;
    }
}

