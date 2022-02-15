namespace CursWork
{
    partial class CursWork
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.hideMenuButton = new System.Windows.Forms.Button();
            this.aboutProgrammButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.theoryButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Goldenrod;
            this.menuPanel.Controls.Add(this.hideMenuButton);
            this.menuPanel.Controls.Add(this.aboutProgrammButton);
            this.menuPanel.Controls.Add(this.testButton);
            this.menuPanel.Controls.Add(this.theoryButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(213, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // hideMenuButton
            // 
            this.hideMenuButton.Location = new System.Drawing.Point(12, 12);
            this.hideMenuButton.Name = "hideMenuButton";
            this.hideMenuButton.Size = new System.Drawing.Size(194, 23);
            this.hideMenuButton.TabIndex = 3;
            this.hideMenuButton.Text = "Скрыть меню";
            this.hideMenuButton.UseVisualStyleBackColor = true;
            // 
            // aboutProgrammButton
            // 
            this.aboutProgrammButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutProgrammButton.Location = new System.Drawing.Point(4, 147);
            this.aboutProgrammButton.Name = "aboutProgrammButton";
            this.aboutProgrammButton.Size = new System.Drawing.Size(206, 38);
            this.aboutProgrammButton.TabIndex = 2;
            this.aboutProgrammButton.Text = "О программе";
            this.aboutProgrammButton.UseVisualStyleBackColor = true;
            this.aboutProgrammButton.Click += new System.EventHandler(this.aboutProgrammButtonOnClick);
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testButton.Location = new System.Drawing.Point(3, 104);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(206, 37);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Тестирование";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButtonOnClick);
            // 
            // theoryButton
            // 
            this.theoryButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryButton.Location = new System.Drawing.Point(4, 61);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(206, 37);
            this.theoryButton.TabIndex = 0;
            this.theoryButton.Text = "Теория";
            this.theoryButton.UseVisualStyleBackColor = true;
            this.theoryButton.Click += new System.EventHandler(this.theoryButtonOnClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(213, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 31);
            this.panel1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(213, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(587, 419);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // CursWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.Name = "CursWork";
            this.Text = "Главное меню";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button aboutProgrammButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button theoryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button hideMenuButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

