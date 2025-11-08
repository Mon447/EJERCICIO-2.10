namespace Ejecicio_2._10
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
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbxEstado = new System.Windows.Forms.ListBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(527, 40);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(149, 22);
            this.txtCapacidad.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(526, 109);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 22);
            this.txtValor.TabIndex = 1;
            // 
            // lbxEstado
            // 
            this.lbxEstado.FormattingEnabled = true;
            this.lbxEstado.ItemHeight = 16;
            this.lbxEstado.Location = new System.Drawing.Point(49, 194);
            this.lbxEstado.Name = "lbxEstado";
            this.lbxEstado.Size = new System.Drawing.Size(489, 244);
            this.lbxEstado.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(207, 78);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(44, 16);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label1";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(576, 217);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(188, 58);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(577, 330);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(187, 57);
            this.btnEnqueue.TabIndex = 5;
            this.btnEnqueue.Text = "ENQUEUE";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(864, 218);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(186, 57);
            this.btnDequeue.TabIndex = 6;
            this.btnDequeue.Text = "DEQUEUE";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(864, 329);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(186, 58);
            this.btnPeek.TabIndex = 7;
            this.btnPeek.Text = "PEEK";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 507);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lbxEstado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCapacidad);
            this.Name = "Form1";
            this.Text = "COLA CIRCULAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ListBox lbxEstado;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnPeek;
    }
}

