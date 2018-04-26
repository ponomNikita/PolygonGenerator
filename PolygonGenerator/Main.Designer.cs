namespace PolygonGenerator
{
    partial class Main
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
            this.Tools = new System.Windows.Forms.Panel();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveAsBtn = new System.Windows.Forms.Button();
            this.PolygonsCount = new System.Windows.Forms.Label();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.Coords = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.Tools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tools.Controls.Add(this.SaveBtn);
            this.Tools.Controls.Add(this.LoadBtn);
            this.Tools.Controls.Add(this.SaveAsBtn);
            this.Tools.Controls.Add(this.PolygonsCount);
            this.Tools.Controls.Add(this.UndoBtn);
            this.Tools.Controls.Add(this.Coords);
            this.Tools.Location = new System.Drawing.Point(790, 12);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(180, 466);
            this.Tools.TabIndex = 1;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoadBtn.Location = new System.Drawing.Point(19, 339);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(142, 23);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveAsBtn.Location = new System.Drawing.Point(19, 397);
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.Size = new System.Drawing.Size(142, 23);
            this.SaveAsBtn.TabIndex = 5;
            this.SaveAsBtn.Text = "Save as";
            this.SaveAsBtn.UseVisualStyleBackColor = true;
            this.SaveAsBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PolygonsCount
            // 
            this.PolygonsCount.AutoSize = true;
            this.PolygonsCount.Location = new System.Drawing.Point(19, 46);
            this.PolygonsCount.Name = "PolygonsCount";
            this.PolygonsCount.Size = new System.Drawing.Size(53, 13);
            this.PolygonsCount.TabIndex = 4;
            this.PolygonsCount.Text = "Polygons:";
            // 
            // UndoBtn
            // 
            this.UndoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UndoBtn.Location = new System.Drawing.Point(19, 426);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(142, 23);
            this.UndoBtn.TabIndex = 3;
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // Coords
            // 
            this.Coords.AutoSize = true;
            this.Coords.Location = new System.Drawing.Point(16, 13);
            this.Coords.Name = "Coords";
            this.Coords.Size = new System.Drawing.Size(30, 13);
            this.Coords.TabIndex = 2;
            this.Coords.Text = "X: Y:";
            // 
            // Container
            // 
            this.Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container.AutoScroll = true;
            this.Container.BackColor = System.Drawing.SystemColors.Window;
            this.Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Container.Location = new System.Drawing.Point(12, 12);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(772, 466);
            this.Container.TabIndex = 3;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBtn.Location = new System.Drawing.Point(19, 368);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(142, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 490);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Tools);
            this.Name = "Main";
            this.Text = "Polygons generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Tools;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Label Coords;
        private System.Windows.Forms.Label PolygonsCount;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveAsBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}

