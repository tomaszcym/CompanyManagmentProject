namespace CompanyManagmentProject
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.taskDescription = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.taskDataTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.taskDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.taskEmployeeSelect = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.taskFinished = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.taskExit = new System.Windows.Forms.Button();
            this.taskDelete = new System.Windows.Forms.Button();
            this.taskSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel31.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(485, 0);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Location = new System.Drawing.Point(7, 165);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.AutoSize = true;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.Location = new System.Drawing.Point(7, 250);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel10.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 72);
            this.label1.TabIndex = 18;
            this.label1.Text = "DANE ZADANIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // taskName
            // 
            this.taskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.taskName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.taskName.ForeColor = System.Drawing.Color.White;
            this.taskName.Location = new System.Drawing.Point(63, 43);
            this.taskName.Margin = new System.Windows.Forms.Padding(2);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(358, 27);
            this.taskName.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.taskName);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 79);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nazwa zadania";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskDescription
            // 
            this.taskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.taskDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.taskDescription.ForeColor = System.Drawing.Color.White;
            this.taskDescription.Location = new System.Drawing.Point(63, 25);
            this.taskDescription.Margin = new System.Windows.Forms.Padding(2);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(358, 88);
            this.taskDescription.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.taskDescription);
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 119);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, -9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Opis zadania";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data rozpoczęcia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.taskDataTimePickerEnd);
            this.panel3.Controls.Add(this.taskDateTimePickerStart);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(1, 277);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 77);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 76);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 110);
            this.panel4.TabIndex = 24;
            // 
            // taskDataTimePickerEnd
            // 
            this.taskDataTimePickerEnd.Location = new System.Drawing.Point(253, 54);
            this.taskDataTimePickerEnd.Margin = new System.Windows.Forms.Padding(2);
            this.taskDataTimePickerEnd.Name = "taskDataTimePickerEnd";
            this.taskDataTimePickerEnd.Size = new System.Drawing.Size(194, 20);
            this.taskDataTimePickerEnd.TabIndex = 23;
            // 
            // taskDateTimePickerStart
            // 
            this.taskDateTimePickerStart.Location = new System.Drawing.Point(45, 54);
            this.taskDateTimePickerStart.Margin = new System.Windows.Forms.Padding(2);
            this.taskDateTimePickerStart.Name = "taskDateTimePickerStart";
            this.taskDateTimePickerStart.Size = new System.Drawing.Size(194, 20);
            this.taskDateTimePickerStart.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(249, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data zakończenia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskEmployeeSelect
            // 
            this.taskEmployeeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.taskEmployeeSelect.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.taskEmployeeSelect.ForeColor = System.Drawing.Color.White;
            this.taskEmployeeSelect.FormattingEnabled = true;
            this.taskEmployeeSelect.Location = new System.Drawing.Point(142, 47);
            this.taskEmployeeSelect.Margin = new System.Windows.Forms.Padding(2);
            this.taskEmployeeSelect.Name = "taskEmployeeSelect";
            this.taskEmployeeSelect.Size = new System.Drawing.Size(194, 29);
            this.taskEmployeeSelect.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.taskEmployeeSelect);
            this.panel5.Location = new System.Drawing.Point(1, 359);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(483, 81);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(2, 86);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(480, 61);
            this.panel6.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(142, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pracownik";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskFinished
            // 
            this.taskFinished.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.taskFinished.ForeColor = System.Drawing.Color.White;
            this.taskFinished.Location = new System.Drawing.Point(185, 15);
            this.taskFinished.Margin = new System.Windows.Forms.Padding(2);
            this.taskFinished.Name = "taskFinished";
            this.taskFinished.Size = new System.Drawing.Size(125, 49);
            this.taskFinished.TabIndex = 25;
            this.taskFinished.Text = "Zakończone";
            this.taskFinished.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.taskFinished);
            this.panel7.Location = new System.Drawing.Point(0, 445);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(484, 81);
            this.panel7.TabIndex = 26;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.taskExit);
            this.panel31.Controls.Add(this.taskDelete);
            this.panel31.Controls.Add(this.taskSave);
            this.panel31.Location = new System.Drawing.Point(1, 531);
            this.panel31.Margin = new System.Windows.Forms.Padding(2);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(487, 71);
            this.panel31.TabIndex = 27;
            // 
            // taskExit
            // 
            this.taskExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(48)))), ((int)(((byte)(111)))));
            this.taskExit.FlatAppearance.BorderSize = 3;
            this.taskExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskExit.ForeColor = System.Drawing.Color.White;
            this.taskExit.Location = new System.Drawing.Point(183, 17);
            this.taskExit.Margin = new System.Windows.Forms.Padding(2);
            this.taskExit.Name = "taskExit";
            this.taskExit.Size = new System.Drawing.Size(117, 36);
            this.taskExit.TabIndex = 4;
            this.taskExit.Text = "Anuluj";
            this.taskExit.UseVisualStyleBackColor = false;
            this.taskExit.Click += new System.EventHandler(this.taskExit_Click);
            // 
            // taskDelete
            // 
            this.taskDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(48)))), ((int)(((byte)(111)))));
            this.taskDelete.FlatAppearance.BorderSize = 3;
            this.taskDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskDelete.ForeColor = System.Drawing.Color.White;
            this.taskDelete.Location = new System.Drawing.Point(31, 17);
            this.taskDelete.Margin = new System.Windows.Forms.Padding(2);
            this.taskDelete.Name = "taskDelete";
            this.taskDelete.Size = new System.Drawing.Size(117, 36);
            this.taskDelete.TabIndex = 5;
            this.taskDelete.Text = "Usuń";
            this.taskDelete.UseVisualStyleBackColor = false;
            this.taskDelete.Click += new System.EventHandler(this.taskDelete_Click);
            // 
            // taskSave
            // 
            this.taskSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(48)))), ((int)(((byte)(111)))));
            this.taskSave.FlatAppearance.BorderSize = 0;
            this.taskSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskSave.ForeColor = System.Drawing.Color.White;
            this.taskSave.Location = new System.Drawing.Point(334, 17);
            this.taskSave.Margin = new System.Windows.Forms.Padding(2);
            this.taskSave.Name = "taskSave";
            this.taskSave.Size = new System.Drawing.Size(117, 36);
            this.taskSave.TabIndex = 3;
            this.taskSave.Text = "Akceptuj";
            this.taskSave.UseVisualStyleBackColor = false;
            this.taskSave.Click += new System.EventHandler(this.taskSave_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(485, 609);
            this.Controls.Add(this.panel31);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.flowLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowe zadanie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker taskDataTimePickerEnd;
        private System.Windows.Forms.DateTimePicker taskDateTimePickerStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox taskEmployeeSelect;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox taskFinished;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Button taskExit;
        private System.Windows.Forms.Button taskDelete;
        private System.Windows.Forms.Button taskSave;
    }
}