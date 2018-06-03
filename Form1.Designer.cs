namespace Chess_Game
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
            this.New_Game_Button = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Game_Button
            // 
            this.New_Game_Button.Location = new System.Drawing.Point(152, 56);
            this.New_Game_Button.Name = "New_Game_Button";
            this.New_Game_Button.Size = new System.Drawing.Size(137, 23);
            this.New_Game_Button.TabIndex = 0;
            this.New_Game_Button.Text = "New Game";
            this.New_Game_Button.UseVisualStyleBackColor = true;
            this.New_Game_Button.Click += new System.EventHandler(this.New_Game_Button_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(152, 85);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(137, 23);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 180);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.New_Game_Button);
            this.Name = "Form1";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_Game_Button;
        private System.Windows.Forms.Button Quit;
    }
}

