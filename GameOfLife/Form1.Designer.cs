namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansza10x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansza10x15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansza15x15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uruchomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.plansza20x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.uruchomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.nowaGraToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.nowaGraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plansza10x10ToolStripMenuItem,
            this.plansza10x15ToolStripMenuItem,
            this.plansza15x15ToolStripMenuItem,
            this.plansza20x10ToolStripMenuItem});
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            // 
            // plansza10x10ToolStripMenuItem
            // 
            this.plansza10x10ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.plansza10x10ToolStripMenuItem.Name = "plansza10x10ToolStripMenuItem";
            this.plansza10x10ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.plansza10x10ToolStripMenuItem.Text = "Plansza 10x10";
            this.plansza10x10ToolStripMenuItem.Click += new System.EventHandler(this.plansza10x10ToolStripMenuItem_Click);
            // 
            // plansza10x15ToolStripMenuItem
            // 
            this.plansza10x15ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.plansza10x15ToolStripMenuItem.Name = "plansza10x15ToolStripMenuItem";
            this.plansza10x15ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.plansza10x15ToolStripMenuItem.Text = "Plansza 10x15";
            this.plansza10x15ToolStripMenuItem.Click += new System.EventHandler(this.plansza10x15ToolStripMenuItem_Click);
            // 
            // plansza15x15ToolStripMenuItem
            // 
            this.plansza15x15ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.plansza15x15ToolStripMenuItem.Name = "plansza15x15ToolStripMenuItem";
            this.plansza15x15ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.plansza15x15ToolStripMenuItem.Text = "Plansza 15x15";
            this.plansza15x15ToolStripMenuItem.Click += new System.EventHandler(this.plansza15x15ToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // uruchomToolStripMenuItem
            // 
            this.uruchomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTimerToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopTimerToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.uruchomToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.uruchomToolStripMenuItem.Name = "uruchomToolStripMenuItem";
            this.uruchomToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.uruchomToolStripMenuItem.Text = "Uruchom";
            // 
            // startTimerToolStripMenuItem
            // 
            this.startTimerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.startTimerToolStripMenuItem.Name = "startTimerToolStripMenuItem";
            this.startTimerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.startTimerToolStripMenuItem.Text = "Start Timer";
            this.startTimerToolStripMenuItem.Click += new System.EventHandler(this.startTimerToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopTimerToolStripMenuItem
            // 
            this.stopTimerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.stopTimerToolStripMenuItem.Name = "stopTimerToolStripMenuItem";
            this.stopTimerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.stopTimerToolStripMenuItem.Text = "Stop Timer";
            this.stopTimerToolStripMenuItem.Click += new System.EventHandler(this.stopTimerToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(28, 42);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1099, 550);
            this.mainPanel.TabIndex = 1;
            // 
            // plansza20x10ToolStripMenuItem
            // 
            this.plansza20x10ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(127)))), ((int)(((byte)(10)))));
            this.plansza20x10ToolStripMenuItem.Name = "plansza20x10ToolStripMenuItem";
            this.plansza20x10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plansza20x10ToolStripMenuItem.Text = "Plansza 20x10";
            this.plansza20x10ToolStripMenuItem.Click += new System.EventHandler(this.plansza20x10ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(140)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1139, 603);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gra w życie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansza10x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansza10x15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansza15x15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uruchomToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem startTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansza20x10ToolStripMenuItem;
    }
}

