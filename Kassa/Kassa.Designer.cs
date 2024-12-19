namespace Kassa
{
    partial class Kassa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kassa));
            this.sale = new System.Windows.Forms.Button();
            this.recovery = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.supply = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sale
            // 
            this.sale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sale.Font = new System.Drawing.Font("Montserrat Medium", 48.75F);
            this.sale.Location = new System.Drawing.Point(646, 355);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(627, 139);
            this.sale.TabIndex = 0;
            this.sale.Text = "продажа";
            this.sale.UseVisualStyleBackColor = false;
            this.sale.Click += new System.EventHandler(this.button1_Click);
            // 
            // recovery
            // 
            this.recovery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recovery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.recovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recovery.Font = new System.Drawing.Font("Montserrat Medium", 18F);
            this.recovery.Image = global::Kassa.Properties.Resources.File_Minus_02;
            this.recovery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recovery.Location = new System.Drawing.Point(646, 515);
            this.recovery.Name = "recovery";
            this.recovery.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.recovery.Size = new System.Drawing.Size(141, 138);
            this.recovery.TabIndex = 1;
            this.recovery.Text = "возврат";
            this.recovery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recovery.UseVisualStyleBackColor = false;
            this.recovery.Click += new System.EventHandler(this.recovery_Click);
            // 
            // inventory
            // 
            this.inventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory.Font = new System.Drawing.Font("Montserrat Medium", 16F);
            this.inventory.Image = global::Kassa.Properties.Resources.File_Search_02;
            this.inventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inventory.Location = new System.Drawing.Point(1132, 515);
            this.inventory.Name = "inventory";
            this.inventory.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.inventory.Size = new System.Drawing.Size(141, 138);
            this.inventory.TabIndex = 2;
            this.inventory.Text = "инвентар-изация";
            this.inventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.button3_Click);
            // 
            // print
            // 
            this.print.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Montserrat Medium", 16F);
            this.print.Image = global::Kassa.Properties.Resources.Image_Indent_Left;
            this.print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.print.Location = new System.Drawing.Point(969, 515);
            this.print.Name = "print";
            this.print.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.print.Size = new System.Drawing.Size(141, 138);
            this.print.TabIndex = 3;
            this.print.Text = "печать этикеток";
            this.print.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.button4_Click);
            // 
            // supply
            // 
            this.supply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.supply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.supply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supply.Font = new System.Drawing.Font("Montserrat Medium", 18F);
            this.supply.Image = global::Kassa.Properties.Resources.Arrow_Up_Square_Contained;
            this.supply.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.supply.Location = new System.Drawing.Point(808, 515);
            this.supply.Name = "supply";
            this.supply.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.supply.Size = new System.Drawing.Size(141, 138);
            this.supply.TabIndex = 4;
            this.supply.Text = "поставка";
            this.supply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.supply.UseVisualStyleBackColor = false;
            this.supply.Click += new System.EventHandler(this.button5_Click);
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(67)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Montserrat Medium", 24F);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.exit.Location = new System.Drawing.Point(646, 674);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(627, 52);
            this.exit.TabIndex = 5;
            this.exit.Text = "выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Kassa.Properties.Resources.Без_имени_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.supply);
            this.Controls.Add(this.print);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.recovery);
            this.Controls.Add(this.sale);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kassa";
            this.Text = "SmartShield - Касса";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button recovery;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button supply;
        private System.Windows.Forms.Button exit;
    }
}

