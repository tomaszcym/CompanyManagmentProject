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
            this.label7 = new System.Windows.Forms.Label();
            this.taskPhoneNumber = new System.Windows.Forms.TextBox();
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
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(647, 0);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Location = new System.Drawing.Point(9, 203);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
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
            this.tableLayoutPanel10.Location = new System.Drawing.Point(9, 308);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel10.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 88);
            this.label1.TabIndex = 18;
            this.label1.Text = "DANE ZADANIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskName
            // 
            this.taskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.taskName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.taskName.ForeColor = System.Drawing.Color.White;
            this.taskName.Location = new System.Drawing.Point(84, 53);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(476, 32);
            this.taskName.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.taskName);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 97);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nazwa zadania";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskDescription
            // 
            this.taskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.taskDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.taskDescription.ForeColor = System.Drawing.Color.White;
            this.taskDescription.Location = new System.Drawing.Point(84, 31);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(476, 108);
            this.taskDescription.TabIndex = 21;
           
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.taskDescription);
            this.panel2.Location = new System.Drawing.Point(0, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 146);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, -11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 40);
            this.label3.TabIndex = 22;
            this.label3.Text = "Opis zadania";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 40);
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
            this.panel3.Location = new System.Drawing.Point(1, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 95);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 135);
            this.panel4.TabIndex = 24;
            // 
            // taskDataTimePickerEnd
            // 
            this.taskDataTimePickerEnd.Location = new System.Drawing.Point(337, 66);
            this.taskDataTimePickerEnd.Name = "taskDataTimePickerEnd";
            this.taskDataTimePickerEnd.Size = new System.Drawing.Size(257, 22);
            this.taskDataTimePickerEnd.TabIndex = 23;
            // 
            // taskDateTimePickerStart
            // 
            this.taskDateTimePickerStart.Location = new System.Drawing.Point(60, 66);
            this.taskDateTimePickerStart.Name = "taskDateTimePickerStart";
            this.taskDateTimePickerStart.Size = new System.Drawing.Size(257, 22);
            this.taskDateTimePickerStart.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(332, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 40);
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
            this.taskEmployeeSelect.Location = new System.Drawing.Point(60, 52);
            this.taskEmployeeSelect.Name = "taskEmployeeSelect";
            this.taskEmployeeSelect.Size = new System.Drawing.Size(257, 31);
            this.taskEmployeeSelect.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.taskPhoneNumber);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.taskEmployeeSelect);
            this.panel5.Location = new System.Drawing.Point(1, 442);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 100);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(640, 75);
            this.panel6.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(337, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 40);
            this.label7.TabIndex = 26;
            this.label7.Text = "Numer telefonu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskPhoneNumber
            // 
            this.taskPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.taskPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.taskPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.taskPhoneNumber.Location = new System.Drawing.Point(337, 52);
            this.taskPhoneNumber.Name = "taskPhoneNumber";
            this.taskPhoneNumber.Size = new System.Drawing.Size(257, 32);
            this.taskPhoneNumber.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pracownik";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskFinished
            // 
            this.taskFinished.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.taskFinished.ForeColor = System.Drawing.Color.White;
            this.taskFinished.Location = new System.Drawing.Point(247, 19);
            this.taskFinished.Name = "taskFinished";
            this.taskFinished.Size = new System.Drawing.Size(167, 60);
            this.taskFinished.TabIndex = 25;
            this.taskFinished.Text = "Zakończone";
            this.taskFinished.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.taskFinished);
            this.panel7.Location = new System.Drawing.Point(0, 548);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(645, 100);
            this.panel7.TabIndex = 26;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.taskExit);
            this.panel31.Controls.Add(this.taskDelete);
            this.panel31.Controls.Add(this.taskSave);
            this.panel31.Location = new System.Drawing.Point(1, 653);
            this.panel31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(649, 87);
            this.panel31.TabIndex = 27;
            // 
            // taskExit
            // 
            this.taskExit.BackColor = System.Drawing.Color.Red;
            this.taskExit.FlatAppearance.BorderSize = 3;
            this.taskExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskExit.ForeColor = System.Drawing.Color.White;
            this.taskExit.Location = new System.Drawing.Point(244, 21);
            this.taskExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskExit.Name = "taskExit";
            this.taskExit.Size = new System.Drawing.Size(156, 44);
            this.taskExit.TabIndex = 4;
            this.taskExit.Text = "Anuluj";
            this.taskExit.UseVisualStyleBackColor = false;
            this.taskExit.Click += new System.EventHandler(this.taskExit_Click);
            // 
            // taskDelete
            // 
            this.taskDelete.BackColor = System.Drawing.Color.Red;
            this.taskDelete.FlatAppearance.BorderSize = 3;
            this.taskDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskDelete.ForeColor = System.Drawing.Color.White;
            this.taskDelete.Location = new System.Drawing.Point(41, 21);
            this.taskDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDelete.Name = "taskDelete";
            this.taskDelete.Size = new System.Drawing.Size(156, 44);
            this.taskDelete.TabIndex = 5;
            this.taskDelete.Text = "Usuń";
            this.taskDelete.UseVisualStyleBackColor = false;
            this.taskDelete.Click += new System.EventHandler(this.taskDelete_Click);
            // 
            // taskSave
            // 
            this.taskSave.BackColor = System.Drawing.Color.Red;
            this.taskSave.FlatAppearance.BorderSize = 0;
            this.taskSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskSave.ForeColor = System.Drawing.Color.White;
            this.taskSave.Location = new System.Drawing.Point(446, 21);
            this.taskSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskSave.Name = "taskSave";
            this.taskSave.Size = new System.Drawing.Size(156, 44);
            this.taskSave.TabIndex = 3;
            this.taskSave.Text = "Akceptuj";
            this.taskSave.UseVisualStyleBackColor = false;
            this.taskSave.Click += new System.EventHandler(this.taskSave_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(647, 749);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowe zadanie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox taskPhoneNumber;
        private System.Windows.Forms.CheckBox taskFinished;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Button taskExit;
        private System.Windows.Forms.Button taskDelete;
        private System.Windows.Forms.Button taskSave;
    }
}