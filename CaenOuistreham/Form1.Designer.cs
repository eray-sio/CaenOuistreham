namespace CaenOuistreham
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxPort = new System.Windows.Forms.GroupBox();
            this.gbxStockage = new System.Windows.Forms.GroupBox();
            this.gbxNavire = new System.Windows.Forms.GroupBox();
            this.gbxAction = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbxPort
            // 
            this.gbxPort.Location = new System.Drawing.Point(35, 27);
            this.gbxPort.Name = "gbxPort";
            this.gbxPort.Size = new System.Drawing.Size(408, 138);
            this.gbxPort.TabIndex = 0;
            this.gbxPort.TabStop = false;
            this.gbxPort.Text = "Port";
            // 
            // gbxStockage
            // 
            this.gbxStockage.Location = new System.Drawing.Point(35, 181);
            this.gbxStockage.Name = "gbxStockage";
            this.gbxStockage.Size = new System.Drawing.Size(408, 140);
            this.gbxStockage.TabIndex = 1;
            this.gbxStockage.TabStop = false;
            this.gbxStockage.Text = "Stockage";
            // 
            // gbxNavire
            // 
            this.gbxNavire.Location = new System.Drawing.Point(35, 337);
            this.gbxNavire.Name = "gbxNavire";
            this.gbxNavire.Size = new System.Drawing.Size(408, 112);
            this.gbxNavire.TabIndex = 2;
            this.gbxNavire.TabStop = false;
            this.gbxNavire.Text = "Navire";
            // 
            // gbxAction
            // 
            this.gbxAction.Location = new System.Drawing.Point(35, 460);
            this.gbxAction.Name = "gbxAction";
            this.gbxAction.Size = new System.Drawing.Size(206, 55);
            this.gbxAction.TabIndex = 3;
            this.gbxAction.TabStop = false;
            this.gbxAction.Text = "Action";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 572);
            this.Controls.Add(this.gbxAction);
            this.Controls.Add(this.gbxNavire);
            this.Controls.Add(this.gbxStockage);
            this.Controls.Add(this.gbxPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPort;
        private System.Windows.Forms.GroupBox gbxStockage;
        private System.Windows.Forms.GroupBox gbxNavire;
        private System.Windows.Forms.GroupBox gbxAction;
    }
}

