
namespace L8_FORMSRAMS_1018822
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.calcularsumatoria = new System.Windows.Forms.Button();
            this.resultadosumatoria = new System.Windows.Forms.Label();
            this.sumatoria = new System.Windows.Forms.TextBox();
            this.labelresultado = new System.Windows.Forms.Label();
            this.labelnumeroingresado = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnfactorial = new System.Windows.Forms.Button();
            this.resultadofactorial = new System.Windows.Forms.Label();
            this.factores = new System.Windows.Forms.Label();
            this.factorial_txt = new System.Windows.Forms.TextBox();
            this.Factorial = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numerotabla = new System.Windows.Forms.TextBox();
            this.btnmultiplicación = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.resultadomultiplicacion = new System.Windows.Forms.Label();
            this.numero1multiplicar = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numeroperfecto = new System.Windows.Forms.TextBox();
            this.resultadonumperfecto = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.btnnumperfecto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(409, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 401);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.calcularsumatoria);
            this.tabPage0.Controls.Add(this.resultadosumatoria);
            this.tabPage0.Controls.Add(this.sumatoria);
            this.tabPage0.Controls.Add(this.labelresultado);
            this.tabPage0.Controls.Add(this.labelnumeroingresado);
            this.tabPage0.Location = new System.Drawing.Point(4, 34);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage0.Size = new System.Drawing.Size(542, 318);
            this.tabPage0.TabIndex = 0;
            this.tabPage0.Text = "Sumatoria";
            this.tabPage0.UseVisualStyleBackColor = true;
            this.tabPage0.Click += new System.EventHandler(this.tabPage0_Click);
            // 
            // calcularsumatoria
            // 
            this.calcularsumatoria.Location = new System.Drawing.Point(35, 219);
            this.calcularsumatoria.Name = "calcularsumatoria";
            this.calcularsumatoria.Size = new System.Drawing.Size(140, 49);
            this.calcularsumatoria.TabIndex = 4;
            this.calcularsumatoria.Text = "Calcular";
            this.calcularsumatoria.UseVisualStyleBackColor = true;
            this.calcularsumatoria.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultadosumatoria
            // 
            this.resultadosumatoria.AutoSize = true;
            this.resultadosumatoria.Location = new System.Drawing.Point(261, 144);
            this.resultadosumatoria.Name = "resultadosumatoria";
            this.resultadosumatoria.Size = new System.Drawing.Size(0, 25);
            this.resultadosumatoria.TabIndex = 3;
            // 
            // sumatoria
            // 
            this.sumatoria.Location = new System.Drawing.Point(266, 79);
            this.sumatoria.Name = "sumatoria";
            this.sumatoria.Size = new System.Drawing.Size(205, 30);
            this.sumatoria.TabIndex = 2;
            this.sumatoria.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.Location = new System.Drawing.Point(55, 144);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(99, 25);
            this.labelresultado.TabIndex = 1;
            this.labelresultado.Text = "Resultado";
            // 
            // labelnumeroingresado
            // 
            this.labelnumeroingresado.AutoSize = true;
            this.labelnumeroingresado.Location = new System.Drawing.Point(55, 79);
            this.labelnumeroingresado.Name = "labelnumeroingresado";
            this.labelnumeroingresado.Size = new System.Drawing.Size(167, 25);
            this.labelnumeroingresado.TabIndex = 0;
            this.labelnumeroingresado.Text = "Ingrese número N";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnfactorial);
            this.tabPage1.Controls.Add(this.resultadofactorial);
            this.tabPage1.Controls.Add(this.factores);
            this.tabPage1.Controls.Add(this.factorial_txt);
            this.tabPage1.Controls.Add(this.Factorial);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 318);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Factorial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnfactorial
            // 
            this.btnfactorial.Location = new System.Drawing.Point(71, 215);
            this.btnfactorial.Name = "btnfactorial";
            this.btnfactorial.Size = new System.Drawing.Size(114, 49);
            this.btnfactorial.TabIndex = 5;
            this.btnfactorial.Text = "Calcular";
            this.btnfactorial.UseVisualStyleBackColor = true;
            this.btnfactorial.Click += new System.EventHandler(this.btnfactorial_Click);
            // 
            // resultadofactorial
            // 
            this.resultadofactorial.AutoSize = true;
            this.resultadofactorial.Location = new System.Drawing.Point(310, 125);
            this.resultadofactorial.Name = "resultadofactorial";
            this.resultadofactorial.Size = new System.Drawing.Size(0, 25);
            this.resultadofactorial.TabIndex = 4;
            // 
            // factores
            // 
            this.factores.AutoSize = true;
            this.factores.Location = new System.Drawing.Point(66, 125);
            this.factores.Name = "factores";
            this.factores.Size = new System.Drawing.Size(134, 25);
            this.factores.TabIndex = 3;
            this.factores.Text = "El factorial de:";
            // 
            // factorial_txt
            // 
            this.factorial_txt.Location = new System.Drawing.Point(310, 43);
            this.factorial_txt.Name = "factorial_txt";
            this.factorial_txt.Size = new System.Drawing.Size(100, 30);
            this.factorial_txt.TabIndex = 2;
            // 
            // Factorial
            // 
            this.Factorial.AutoSize = true;
            this.Factorial.Location = new System.Drawing.Point(62, 46);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(186, 25);
            this.Factorial.TabIndex = 1;
            this.Factorial.Text = "Ingrese un número: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numerotabla);
            this.tabPage2.Controls.Add(this.btnmultiplicación);
            this.tabPage2.Controls.Add(this.resultado);
            this.tabPage2.Controls.Add(this.resultadomultiplicacion);
            this.tabPage2.Controls.Add(this.numero1multiplicar);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 363);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Tablas de multiplicar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numerotabla
            // 
            this.numerotabla.Location = new System.Drawing.Point(307, 34);
            this.numerotabla.Name = "numerotabla";
            this.numerotabla.Size = new System.Drawing.Size(100, 30);
            this.numerotabla.TabIndex = 7;
            // 
            // btnmultiplicación
            // 
            this.btnmultiplicación.Location = new System.Drawing.Point(72, 145);
            this.btnmultiplicación.Name = "btnmultiplicación";
            this.btnmultiplicación.Size = new System.Drawing.Size(128, 35);
            this.btnmultiplicación.TabIndex = 6;
            this.btnmultiplicación.Text = "Calcular";
            this.btnmultiplicación.UseVisualStyleBackColor = true;
            this.btnmultiplicación.Click += new System.EventHandler(this.btnmultiplicación_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(67, 87);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(146, 25);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "El resultado es:";
            // 
            // resultadomultiplicacion
            // 
            this.resultadomultiplicacion.AutoSize = true;
            this.resultadomultiplicacion.Location = new System.Drawing.Point(248, 87);
            this.resultadomultiplicacion.Name = "resultadomultiplicacion";
            this.resultadomultiplicacion.Size = new System.Drawing.Size(0, 25);
            this.resultadomultiplicacion.TabIndex = 2;
            // 
            // numero1multiplicar
            // 
            this.numero1multiplicar.AutoSize = true;
            this.numero1multiplicar.Location = new System.Drawing.Point(67, 32);
            this.numero1multiplicar.Name = "numero1multiplicar";
            this.numero1multiplicar.Size = new System.Drawing.Size(181, 25);
            this.numero1multiplicar.TabIndex = 0;
            this.numero1multiplicar.Text = "Ingrese un número:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.numeroperfecto);
            this.tabPage3.Controls.Add(this.resultadonumperfecto);
            this.tabPage3.Controls.Add(this.num1);
            this.tabPage3.Controls.Add(this.btnnumperfecto);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(542, 318);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Número perfecto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numeroperfecto
            // 
            this.numeroperfecto.Location = new System.Drawing.Point(302, 63);
            this.numeroperfecto.Name = "numeroperfecto";
            this.numeroperfecto.Size = new System.Drawing.Size(100, 30);
            this.numeroperfecto.TabIndex = 3;
            this.numeroperfecto.TextChanged += new System.EventHandler(this.numeroperfecto_TextChanged);
            // 
            // resultadonumperfecto
            // 
            this.resultadonumperfecto.AutoSize = true;
            this.resultadonumperfecto.Location = new System.Drawing.Point(69, 125);
            this.resultadonumperfecto.Name = "resultadonumperfecto";
            this.resultadonumperfecto.Size = new System.Drawing.Size(0, 25);
            this.resultadonumperfecto.TabIndex = 2;
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(69, 61);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(181, 25);
            this.num1.TabIndex = 1;
            this.num1.Text = "Ingrese un número:";
            // 
            // btnnumperfecto
            // 
            this.btnnumperfecto.Location = new System.Drawing.Point(74, 205);
            this.btnnumperfecto.Name = "btnnumperfecto";
            this.btnnumperfecto.Size = new System.Drawing.Size(115, 40);
            this.btnnumperfecto.TabIndex = 0;
            this.btnnumperfecto.Text = "Calcular";
            this.btnnumperfecto.UseVisualStyleBackColor = true;
            this.btnnumperfecto.Click += new System.EventHandler(this.btnnumperfecto_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sumatoria",
            "Factorial",
            "Tablas de multiplicar",
            "Número perfecto"});
            this.comboBox1.Location = new System.Drawing.Point(26, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(200, 25);
            this.labeltitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(330, 32);
            this.labeltitulo.TabIndex = 5;
            this.labeltitulo.Text = "LABORATORIO 8 FORM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labeltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Label resultadosumatoria;
        private System.Windows.Forms.TextBox sumatoria;
        private System.Windows.Forms.Label labelresultado;
        private System.Windows.Forms.Label labelnumeroingresado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Button calcularsumatoria;
        private System.Windows.Forms.Button btnfactorial;
        private System.Windows.Forms.Label resultadofactorial;
        private System.Windows.Forms.Label factores;
        private System.Windows.Forms.TextBox factorial_txt;
        private System.Windows.Forms.Label Factorial;
        private System.Windows.Forms.Button btnmultiplicación;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label resultadomultiplicacion;
        private System.Windows.Forms.Label numero1multiplicar;
        private System.Windows.Forms.Label resultadonumperfecto;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Button btnnumperfecto;
        private System.Windows.Forms.TextBox numeroperfecto;
        private System.Windows.Forms.TextBox numerotabla;
    }
}

