namespace NotePad
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приблизитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.встаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.новоеОкноToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // новоеОкноToolStripMenuItem
            // 
            this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
            this.новоеОкноToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.новоеОкноToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.новоеОкноToolStripMenuItem.Text = "Новое окно";
            this.новоеОкноToolStripMenuItem.Click += new System.EventHandler(this.новоеОкноToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.Print);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.встаToolStripMenuItem,
            this.вырезатьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.цветToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.ColorText);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 29);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приблизитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem});
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // приблизитьToolStripMenuItem
            // 
            this.приблизитьToolStripMenuItem.Name = "приблизитьToolStripMenuItem";
            this.приблизитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.приблизитьToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.приблизитьToolStripMenuItem.Text = "Приблизить";
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.Reference);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 417);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F14)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.Copy);
            // 
            // встаToolStripMenuItem
            // 
            this.встаToolStripMenuItem.Name = "встаToolStripMenuItem";
            this.встаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F15)));
            this.встаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.встаToolStripMenuItem.Text = "Вставить";
            this.встаToolStripMenuItem.Click += new System.EventHandler(this.Paste);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F16)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.Cut);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "NoteBook";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem масштабToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приблизитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem встаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
    }
}

