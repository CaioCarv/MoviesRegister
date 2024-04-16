using System.Windows.Forms;

namespace MoviesRegister.UI
{
    partial class MoviesForm
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
            this.ptbPosterFilme = new System.Windows.Forms.PictureBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDataLancamento = new System.Windows.Forms.Label();
            this.lblLinguagemOriginal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPopularidade = new System.Windows.Forms.Label();
            this.lblMediaVotos = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.lblTituloOriginal = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.txtDataLancamento = new System.Windows.Forms.Label();
            this.txtLinguagemOriginal = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtTituloOriginal = new System.Windows.Forms.Label();
            this.txtMediaVotos = new System.Windows.Forms.Label();
            this.txtOverview = new System.Windows.Forms.Label();
            this.txtPopularidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPosterFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbPosterFilme
            // 
            this.ptbPosterFilme.Location = new System.Drawing.Point(12, 12);
            this.ptbPosterFilme.Name = "ptbPosterFilme";
            this.ptbPosterFilme.Size = new System.Drawing.Size(235, 277);
            this.ptbPosterFilme.TabIndex = 0;
            this.ptbPosterFilme.TabStop = false;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMovie.Image = global::MoviesRegister.Properties.Resources.favoritar;
            this.btnAddMovie.Location = new System.Drawing.Point(516, 314);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(80, 30);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Adicionar";
            this.btnAddMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(275, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Código:";
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataLancamento.Location = new System.Drawing.Point(275, 180);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(129, 13);
            this.lblDataLancamento.TabIndex = 2;
            this.lblDataLancamento.Text = "Data de Lançamento:";
            // 
            // lblLinguagemOriginal
            // 
            this.lblLinguagemOriginal.AutoSize = true;
            this.lblLinguagemOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinguagemOriginal.Location = new System.Drawing.Point(275, 60);
            this.lblLinguagemOriginal.Name = "lblLinguagemOriginal";
            this.lblLinguagemOriginal.Size = new System.Drawing.Size(119, 13);
            this.lblLinguagemOriginal.TabIndex = 2;
            this.lblLinguagemOriginal.Text = "Linguagem Original:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(275, 220);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título:";
            // 
            // lblPopularidade
            // 
            this.lblPopularidade.AutoSize = true;
            this.lblPopularidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularidade.Location = new System.Drawing.Point(275, 140);
            this.lblPopularidade.Name = "lblPopularidade";
            this.lblPopularidade.Size = new System.Drawing.Size(85, 13);
            this.lblPopularidade.TabIndex = 4;
            this.lblPopularidade.Text = "Popularidade:";
            // 
            // lblMediaVotos
            // 
            this.lblMediaVotos.AutoSize = true;
            this.lblMediaVotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaVotos.Location = new System.Drawing.Point(275, 260);
            this.lblMediaVotos.Name = "lblMediaVotos";
            this.lblMediaVotos.Size = new System.Drawing.Size(99, 13);
            this.lblMediaVotos.TabIndex = 5;
            this.lblMediaVotos.Text = "Média de Votos:";
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverview.Location = new System.Drawing.Point(275, 300);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(110, 13);
            this.lblOverview.TabIndex = 7;
            this.lblOverview.Text = "Overview:";
            // 

            // lblTituloOriginal
            // 
            this.lblTituloOriginal.AutoSize = true;
            this.lblTituloOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloOriginal.Location = new System.Drawing.Point(275, 100);
            this.lblTituloOriginal.Name = "lblTituloOriginal";
            this.lblTituloOriginal.Size = new System.Drawing.Size(92, 13);
            this.lblTituloOriginal.TabIndex = 6;
            this.lblTituloOriginal.Text = "Título Original:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(410, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(49, 13);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Text = "CODIGO";
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.AutoSize = true;
            this.txtDataLancamento.Location = new System.Drawing.Point(410, 180);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.Size = new System.Drawing.Size(116, 13);
            this.txtDataLancamento.TabIndex = 2;
            this.txtDataLancamento.Text = "DATA_LANCAMENTO";
            // 
            // txtLinguagemOriginal
            // 
            this.txtLinguagemOriginal.AutoSize = true;
            this.txtLinguagemOriginal.Location = new System.Drawing.Point(410, 60);
            this.txtLinguagemOriginal.Name = "txtLinguagemOriginal";
            this.txtLinguagemOriginal.Size = new System.Drawing.Size(128, 13);
            this.txtLinguagemOriginal.TabIndex = 2;
            this.txtLinguagemOriginal.Text = "LINGUAGEM_ORIGINAL";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Location = new System.Drawing.Point(410, 220);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(46, 13);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.Text = "TITULO";
            // 
            // txtTituloOriginal
            // 
            this.txtTituloOriginal.AutoSize = true;
            this.txtTituloOriginal.Location = new System.Drawing.Point(410, 100);
            this.txtTituloOriginal.Name = "txtTituloOriginal";
            this.txtTituloOriginal.Size = new System.Drawing.Size(103, 13);
            this.txtTituloOriginal.TabIndex = 6;
            this.txtTituloOriginal.Text = "TITULO_ORIGINAL";
            // 
            // txtMediaVotos
            // 
            this.txtMediaVotos.AutoSize = true;
            this.txtMediaVotos.Location = new System.Drawing.Point(410, 260);
            this.txtMediaVotos.Name = "txtMediaVotos";
            this.txtMediaVotos.Size = new System.Drawing.Size(84, 13);
            this.txtMediaVotos.TabIndex = 5;
            this.txtMediaVotos.Text = "MEDIA_VOTOS";
            // 
            // txtOverview
            // 
            this.txtOverview.AutoSize = true;
            this.txtOverview.Location = new System.Drawing.Point(410, 300);
            this.txtOverview.Name = "txtOverview";
            this.txtOverview.Size = new System.Drawing.Size(95, 13);
            this.txtOverview.TabIndex = 6;
            this.txtOverview.Text = "OVERVIEW";
            // 
            // txtPopularidade
            // 
            this.txtPopularidade.AutoSize = true;
            this.txtPopularidade.Location = new System.Drawing.Point(410, 140);
            this.txtPopularidade.Name = "txtPopularidade";
            this.txtPopularidade.Size = new System.Drawing.Size(91, 13);
            this.txtPopularidade.TabIndex = 4;
            this.txtPopularidade.Text = "POPULARIDADE";
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 380);
            this.Controls.Add(this.txtPopularidade);
            this.Controls.Add(this.lblPopularidade);
            this.Controls.Add(this.txtMediaVotos);
            this.Controls.Add(this.lblMediaVotos);
            this.Controls.Add(this.txtTituloOriginal);
            this.Controls.Add(this.lblTituloOriginal);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtLinguagemOriginal);
            this.Controls.Add(this.lblLinguagemOriginal);
            this.Controls.Add(this.txtDataLancamento);
            this.Controls.Add(this.lblDataLancamento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtOverview);
            this.Controls.Add(this.lblOverview);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.ptbPosterFilme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Filme";
            ((System.ComponentModel.ISupportInitialize)(this.ptbPosterFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbPosterFilme;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDataLancamento;
        private System.Windows.Forms.Label lblLinguagemOriginal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPopularidade;
        private System.Windows.Forms.Label lblMediaVotos;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Label lblTituloOriginal;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label txtDataLancamento;
        private System.Windows.Forms.Label txtLinguagemOriginal;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label txtTituloOriginal;
        private System.Windows.Forms.Label txtMediaVotos;
        private System.Windows.Forms.Label txtOverview;
        private System.Windows.Forms.Label txtPopularidade;

    }
}