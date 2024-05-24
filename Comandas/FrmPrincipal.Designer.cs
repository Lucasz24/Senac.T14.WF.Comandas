﻿namespace Comandas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCardapio = new ReaLTaiizor.Controls.MetroButton();
            btnComanda = new ReaLTaiizor.Controls.MetroButton();
            btnPedidoCozinha = new ReaLTaiizor.Controls.MetroButton();
            Usuarios = new ReaLTaiizor.Controls.MetroButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Usuarios);
            groupBox1.Controls.Add(btnPedidoCozinha);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.Location = new Point(12, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnCardapio
            // 
            btnCardapio.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledForeColor = Color.Gray;
            btnCardapio.Font = new Font("Microsoft Sans Serif", 10F);
            btnCardapio.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverTextColor = Color.White;
            btnCardapio.IsDerivedStyle = true;
            btnCardapio.Location = new Point(27, 60);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalTextColor = Color.White;
            btnCardapio.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressTextColor = Color.White;
            btnCardapio.Size = new Size(127, 129);
            btnCardapio.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnCardapio.StyleManager = null;
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardapio";
            btnCardapio.ThemeAuthor = "Taiizor";
            btnCardapio.ThemeName = "MetroLight";
            btnCardapio.Click += metroButton1_Click;
            // 
            // btnComanda
            // 
            btnComanda.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledForeColor = Color.Gray;
            btnComanda.Font = new Font("Microsoft Sans Serif", 10F);
            btnComanda.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverTextColor = Color.White;
            btnComanda.IsDerivedStyle = true;
            btnComanda.Location = new Point(196, 60);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalTextColor = Color.White;
            btnComanda.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressTextColor = Color.White;
            btnComanda.Size = new Size(127, 129);
            btnComanda.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnComanda.StyleManager = null;
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.ThemeAuthor = "Taiizor";
            btnComanda.ThemeName = "MetroLight";
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidoCozinha.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidoCozinha.DisabledForeColor = Color.Gray;
            btnPedidoCozinha.Font = new Font("Microsoft Sans Serif", 10F);
            btnPedidoCozinha.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnPedidoCozinha.HoverColor = Color.FromArgb(95, 207, 255);
            btnPedidoCozinha.HoverTextColor = Color.White;
            btnPedidoCozinha.IsDerivedStyle = true;
            btnPedidoCozinha.Location = new Point(384, 60);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalTextColor = Color.White;
            btnPedidoCozinha.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressTextColor = Color.White;
            btnPedidoCozinha.Size = new Size(127, 129);
            btnPedidoCozinha.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnPedidoCozinha.StyleManager = null;
            btnPedidoCozinha.TabIndex = 2;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.ThemeAuthor = "Taiizor";
            btnPedidoCozinha.ThemeName = "MetroLight";
            btnPedidoCozinha.Click += metroButton3_Click;
            // 
            // Usuarios
            // 
            Usuarios.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            Usuarios.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            Usuarios.DisabledForeColor = Color.Gray;
            Usuarios.Font = new Font("Microsoft Sans Serif", 10F);
            Usuarios.HoverBorderColor = Color.FromArgb(95, 207, 255);
            Usuarios.HoverColor = Color.FromArgb(95, 207, 255);
            Usuarios.HoverTextColor = Color.White;
            Usuarios.IsDerivedStyle = true;
            Usuarios.Location = new Point(570, 60);
            Usuarios.Name = "Usuarios";
            Usuarios.NormalBorderColor = Color.FromArgb(65, 177, 225);
            Usuarios.NormalColor = Color.FromArgb(65, 177, 225);
            Usuarios.NormalTextColor = Color.White;
            Usuarios.PressBorderColor = Color.FromArgb(35, 147, 195);
            Usuarios.PressColor = Color.FromArgb(35, 147, 195);
            Usuarios.PressTextColor = Color.White;
            Usuarios.Size = new Size(142, 129);
            Usuarios.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            Usuarios.StyleManager = null;
            Usuarios.TabIndex = 3;
            Usuarios.ThemeAuthor = "Taiizor";
            Usuarios.ThemeName = "MetroLight";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmPrincipal";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MetroButton Usuarios;
        private ReaLTaiizor.Controls.MetroButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.MetroButton btnComanda;
        private ReaLTaiizor.Controls.MetroButton btnCardapio;
    }
}